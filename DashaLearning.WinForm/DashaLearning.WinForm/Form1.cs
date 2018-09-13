using DashaLearning.DataBase.Npgsql;
using DashaLearning.RepositoryContract;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DashaLearning.WinForm
{
    public partial class Form1 : Form
    {
        private IUserRepository _userRepository;
        private IPersonRepository _personRepository;

        public Form1()
        {
            InitializeComponent();
            InitRepos();
        }

        private void InitRepos()
        {
            _userRepository = new UserRepository();
            _personRepository = new PersonRepository();
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
                MessageBox.Show("Неверный формат id");
            }
            catch (Exception ex)
            {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void ButtonGetPersonByIdLite(object sender, EventArgs e)
        {
            try
            {
                
                var persons = await _personRepository.GetAllPersonsLite();
                if (persons != null && persons.Any())
                {
                    string personsInfo = "";
                    foreach (var person in persons)
                    {
                        personsInfo += $"id: {person.Id}, имя: {person.Name}, пол: {person.Male}{Environment.NewLine}";
                    }

                    MessageBox.Show($"Пользователи:{Environment.NewLine}{personsInfo}");
                }
                else
                {
                    MessageBox.Show("Пока нет ни одного пользователя");
                }
                MessageBox.Show("fgjhfgя");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так, тварь");
            }
        }
    }
}
