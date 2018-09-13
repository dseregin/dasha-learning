using DashaLearning.BaseComponent;
using DashaLearning.BaseComponent.Help;
using DashaLearning.DataBase.Npgsql;
using DashaLearning.RepositoryContract;
using NLog;
using System;
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

            InitializeComponent();
            InitRepos();
        }

        private void InitRepos()
        {
            _logger.Info("Инициализация репозиториев...");
            try
            {
                _userRepository = new UserRepository();

                _logger.Info("Инициализация репозиториев выполнена");
            }
            catch (Exception ex)
            {
                var detail = $"Ошибка Инициализации репозиториев: {ErrorProcessing.ExceptionMessageToString(ex)}";
                _logger.Error(detail);
            }

        }

        private async void ButtonGetUserByIdLite(object sender, EventArgs e)
        {
            try
            {
                var id = userIdTextBox.Text;
                var user = await _userRepository.GetUserByIdLite(Guid.Parse(id));

                MessageBox.Show($"Логин: {user.Login}, Пароль: {user.Password}, онлайн: {(user.IsOnline ? "Да" : "нет")}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Неверный формат id");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так, мразь");
            }
        }

        private async void ButtonGetUserById(object sender, EventArgs e)
        {
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
                var detail = $"Неверный формат id.{Environment.NewLine}{ErrorProcessing.ExceptionMessageToString(ex)}";
                _logger.Error(detail);
                MessageBox.Show("Неверный формат id");
            }
            catch (Exception ex)
            {
                var detail = $"Что-то пошло не так, мразь. {Environment.NewLine}{ErrorProcessing.ExceptionMessageToString(ex)}";
                _logger.Error(detail);
                MessageBox.Show("Что-то пошло не так, мразь");
            }
        }

        private async void ButtonGetAllUsersLite(object sender, EventArgs e)
        {
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
                MessageBox.Show("Что-то пошло не так, мразь");
            }
        }
    }
}
