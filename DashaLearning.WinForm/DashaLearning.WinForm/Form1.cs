using DashaLearning.DataBase.Npgsql;
using DashaLearning.RepositoryContract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashaLearning.WinForm
{
    public partial class Form1 : Form
    {
        private string _connectionString = "Server=localhost;Port=5432;Database=game_db;Persist Security Info=True;uid=postgres;pwd=postgres;Pooling=true;MaxPoolSize=1000;Timeout=300;CommandTimeout=300;";
        private IUserRepository _userRepository;

        public Form1()
        {
            InitializeComponent();
            InitRepos();
        }

        private void InitRepos()
        {
            _userRepository = new UserRepository(_connectionString);
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
            //////
        }
    }
}
