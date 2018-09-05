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

        private async void Button1_Click(object sender, EventArgs e)
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

        private async void button2_Click(object sender, EventArgs e)
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
            //////
        }
    }
}
