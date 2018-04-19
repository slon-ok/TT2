using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace ТТ2 {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        // testovii commit
        // fuck fuck fuck
        public string user;
        DB db = new DB();
        bool EnterButton = true;
        bool regButton = true;

        private void closeButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void closeButton2_Click(object sender, EventArgs e) {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // создание базы и таблиц при загрузке страницы
            db.SearchDB();
        }

        //метод проверки поля на пустой ввод
        public bool checkFieldEmpty(string checkingString) {
            if(checkingString.Equals("")) {
                return true;
            } else {
                return false;
            }
        }

        // кнопка "Добавить пользователя"
        private void registrationButton_Click(object sender, EventArgs e) {
            if (regButton) {
                Registration();
            }
        }

        public void Registration() { 
            string login = loginBoxReg.Text;
            string password = passwordBoxReg.Text;
            //запрос проверки на существование

            if(checkFieldEmpty(login) || checkFieldEmpty(password)) {
                labelLoginReg.ForeColor = Color.Crimson;
                labelLoginReg.Text = "Необходимо заполнить все поля!";
                 return;
            }

            string query = @"SELECT rowid FROM Login WHERE Name ='" + login + "'";
            // запрос добавления нового пользователя
            string insertQuery = @"INSERT INTO 'Login' ('Name', 'Password') VALUES ('" + login + "', '" + password + "')";

            if (db.DBConnectComparison(query)) {
                labelLoginReg.ForeColor = Color.Crimson;
                labelLoginReg.Text = "Такой пользователь уже существует!";
            } else {
                db.DBConnectNonExecute(insertQuery);
                loginBoxReg.Text = "";
                passwordBoxReg.Text = "";
                labelLoginReg.ForeColor = Color.FromArgb(0x7024AD);

                //Добавление нового общего задания при регистрации, во избежание краха. 

                DateTime firstDate = DateTime.Now;
                string firstDateStr = firstDate.ToString("d");
                string firstMainTaskQuery = @"INSERT INTO 'MainTable' ('UserName', 'TaskName', 'TaskDeskription', 'TaskAddTime', 'TaskDoneTime', 'TaskDone', 'IsTaskMain')
                            VALUES ('" + login + "', 'First main task', 'It is first main task.', '" + firstDateStr + "', '" +
                            firstDateStr + "', '0', '-1')";
                db.DBConnectNonExecute(firstMainTaskQuery);

                labelLoginReg.Text = "Пользователь зарегистрирован!";
                // защита от повторного нажатия
                //regButton = false;
            }


        }

        // авторизация
        private void loginButton_Click(object sender, EventArgs e) {
            if(EnterButton) {
                EnterApp();
            } 

        }

        private async void EnterApp() { 
            string login = loginBox.Text;
            string password = passwordBox.Text;
            // проверка на пустые поля
            if(checkFieldEmpty(login) || checkFieldEmpty(password)) {
                labelLogin.ForeColor = Color.Crimson;
                labelLogin.Text = "Необходимо заполнить все поля!";
                return;
            }

            string query = @"SELECT rowid FROM Login WHERE Name ='" + login + "' AND Password = '" + password + "'";
            // сравнение с базой и авторизация.
            if (db.DBConnectComparison(query)) {

                labelLogin.ForeColor = Color.FromArgb(0x7024AD);
                labelLogin.Text = "Здравствуйте, " + login + "!";

                // защита от повторного нажатия
                EnterButton = false;

                user = login;

                await Task.Delay(2000);
                this.Hide();

                mainForm MainForm = new mainForm();
                MainForm.Owner = this; // задаем новой форме владельца
                MainForm.ShowDialog(this);
                this.Close();
            }
            else {
                labelLogin.ForeColor = Color.Crimson;
                labelLogin.Text = "Логин или пароль указаны не верно!";
            }

        }
    }

}
