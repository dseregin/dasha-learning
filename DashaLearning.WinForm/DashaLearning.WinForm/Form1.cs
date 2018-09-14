using DashaLearning.BaseComponent;
using DashaLearning.BaseComponent.Help;
using DashaLearning.BaseComponent.Mail;
using DashaLearning.DataBase.Npgsql;
using DashaLearning.RepositoryContract;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DashaLearning.WinForm
{
    public partial class Form1 : Form
    {
        private IUserRepository _userRepository;

        private ILogger _logger;

        public Form1()
        {
            Initialize();
        }

        private void Initialize()
        {
            var container = DiContainer.GetContainer();
            _logger = container.GetInstance<ILogger>();
            LogMethodHelper.Logger = _logger;

            InitializeComponent();
            InitRepos();
        }

        private void InitRepos()
        {
            _logger.Debug("Инициализация репозиториев...");
            try
            {
                _userRepository = new UserRepository();

                _logger.Debug("Инициализация репозиториев выполнена");
            }
            catch (Exception ex)
            {
                var detail = $"Ошибка Инициализации репозиториев: {ErrorProcessing.ExceptionMessageToString(ex)}";
                _logger.Error(detail);
            }
        }

        private void LogDetailError(string message, Exception ex)
        {
            var detail = $"{message}: {ErrorProcessing.ExceptionMessageToString(ex)}";
            _logger.Error(detail);
            MessageBox.Show($"{message}");
        }

        private async void ButtonGetUserByIdLite(object sender, EventArgs e)
        {
            this.LogOnMethodEnter();
            try
            {
                var id = userIdTextBox.Text;
                var user = await _userRepository.GetUserByIdLite(Guid.Parse(id));

                MessageBox.Show($"Логин: {user.Login}, Пароль: {user.Password}, онлайн: {(user.IsOnline ? "Да" : "нет")}");
            }
            catch (FormatException ex)
            {
                var message = "Неверный формат id";
                LogDetailError(message, ex);
            }
            catch (Exception ex)
            {
                var message = "Что-то пошло не так, мразь";
                LogDetailError(message, ex);
            }
            this.LogOnMethodExit();
        }

        private async void ButtonGetUserById(object sender, EventArgs e)
        {
            this.LogOnMethodEnter();
            try
            {
                var id = userIdTextBox.Text;
                var user = await _userRepository.GetUserById(Guid.Parse(id));

                string personsInfo = "";

                if (user != null)
                {
                    foreach (var person in user.Persons)
                    {
                        personsInfo += $"Имя: {person.Name}, пол: {(person.Male ? "муж" : "жен")}{Environment.NewLine}";
                    }

                    MessageBox.Show($"Логин: {user.Login}, персонажи: {Environment.NewLine}{personsInfo}");
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует");
                }
            }
            catch (FormatException ex)
            {
                var message = "Неверный формат id";
                LogDetailError(message, ex);
            }
            catch (Exception ex)
            {
                var message = "Что-то пошло не так, мразь";
                LogDetailError(message, ex);
            }
            this.LogOnMethodExit();
        }

        private async void ButtonGetAllUsersLite(object sender, EventArgs e)
        {
            this.LogOnMethodEnter();

            //var mailSettings = new MailSettings()
            //{
            //    EmailHost = ConfigHelper.EmailHost,
            //    EmailPort = ConfigHelper.EmailPort,
            //    EmailUserName = ConfigHelper.EmailUserName,
            //    EmailPassword = ConfigHelper.EmailPassword,
            //    EmailSSLEnabled = ConfigHelper.EmailSSLEnabled
            //};

            //var emails = new List<string>() { "sederom3@mail.ru" };
            //MailSender.SendEmail(mailSettings, emails.ToArray(), "Test mail send", "Password");

            try
            {
                var users = await _userRepository.GetAllUsersLite();
                if (users != null && users.Any())
                {
                    string usersInfo = "";
                    foreach (var user in users)
                    {
                        usersInfo += $"id: {user.Id}, логин: {user.Login}, онлайн: {(user.IsOnline ? "да" : "нет")}{Environment.NewLine}";
                    }

                    MessageBox.Show($"Пользователи:{Environment.NewLine}{usersInfo}");
                }
                else
                {
                    MessageBox.Show("Пока нет ни одного пользователя");
                }
            }
            catch (Exception ex)
            {
                var message = "Что-то пошло не так, мразь";
                LogDetailError(message, ex);
            }
            this.LogOnMethodExit();
        }
    }
}
