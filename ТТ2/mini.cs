using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТТ2 {
    public partial class mini : Form {
        public mini() {
            InitializeComponent();
        }

        string user;
        mainForm mf;
        public List<string> selectRow;
        

        // исчезание комбобокса при выборе общей задачи
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                comboBox1.Visible = false;
                checkBoxAll.Visible = false;
            } else {
                comboBox1.Visible = true;
                checkBoxAll.Visible = true;
            }
        }
        

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        private void mini_Load(object sender, EventArgs e) {
            mf = (mainForm)this.Owner;
            user = mf.user;
        }

        // добавить задание--------------------------------------------
        private void addNewTask_Click(object sender, EventArgs e) {
            AddTask();
        }
        // изменить задание -------------------------------------------
        private void changeButton_Click(object sender, EventArgs e) {
            changeTaskMini();
        }
        // изменение состояния чекбокса----------------------------
        public void checkBoxStateChange(bool state) {
            checkBox1.Checked = state;
        }

        // включение и отключение чекбокса -----------------------
        public void checkBoxOn(bool state) {
            checkBox1.Enabled = state;
            checkBoxAll.Enabled = state;
        }
    
        // добавление элементов в комбобокс----------------------------
        public void comboSet(Dictionary<string, string> strList) {
            comboBox1.DataSource = new BindingSource(strList, null);
            comboBox1.ValueMember = "Key";
            comboBox1.DisplayMember = "Value";
        }

        // смена выделенного элемента
        public void comboBoxSelectedChange(int key) {
            comboBox1.SelectedIndex = key;
        }

        //методы скрывания и отображения комбобокса -------------------
        public void comboVisible(bool visible) {
            comboBox1.Visible = visible;
            checkBoxAll.Visible = visible;
        }

        // методы скрывания кнопок ------------------------------------
        public void addButtonVisible(bool visible) {
            addNewTask.Visible = visible;
        }

        public void changeButtonVisible(bool visible) {
            changeButton.Visible = visible;
        }

        // методы задавания текста полям -------------------------------
        public void SetNameBox(string Name) {
            nameBox.Text = Name;
        }

        public void SetDeskrBox(string deskr) {
            deskrBox.Text = deskr;
        }

        // метод добавления задачи-------------------------------------
        public void AddTask() {
            if (nameBox.Text.Equals("") || deskrBox.Text.Equals("")) {
                messageLabel.ForeColor = Color.DarkRed;
                messageLabel.Text = "Необходимо заполнить все поля!";
                return;
            }
            //поля
            double days;
            Double.TryParse(countDayBox.Text, out days);
            int mTask;
            string mTaskStr;
            //проверка чекбокса на основное задание
            if (checkBox1.Checked) {
                mTask = 1;
            }
            else {
                //выдирание номера общей задачи из комбобокса
                mTaskStr = comboBox1.SelectedItem.ToString();
                char symbol = ',';
                string str = mTaskStr.Substring(1, mTaskStr.IndexOf(symbol) - 1);
                int.TryParse(str, out mTask);
            }
            Tsk task = new ТТ2.Tsk(user, nameBox.Text, deskrBox.Text, days, mTask);
            task.AddTask();
            mf.textBoxShow("Задание добавлено!");

            
            TreeView tree = new TreeView();

            //метод для изменения индекса общей задачи -------------------------
            // обновляем общую задачу
            tree.updateMainRow(mTask.ToString(), user);

            mf.ViewNotDone();

            this.Hide();
        }

        // метод изменения задачи------------------------------------------------
        public void changeTaskMini() {
            // проверка на пустое поле 
            if (nameBox.Text.Equals("") || deskrBox.Text.Equals("")) {
                messageLabel.Text = "Необходимо заполнить все поля!";
                return;
            }


            // вычисляем переменные
            string taskDoneTimeStr;
            double days;
            Double.TryParse(countDayBox.Text, out days);

            if(days == 0) {
                taskDoneTimeStr = selectRow[5];
            }
            else {
                string[] ddmmyy = selectRow[5].Split('.');
                string yymmdd = ddmmyy[2] + "-" + ddmmyy[1] + "-" + ddmmyy[0];
                DateTime taskDoneTime = DateTime.Parse(yymmdd);
                taskDoneTimeStr = taskDoneTime.AddDays(days).ToString("d"); 
            }

            //проверка чекбокса на основное задание
            string mTaskStr;
            if (checkBox1.Checked) {
                mTaskStr = 1.ToString();

            }
            else {
                //выдирание номера общей задачи из комбобокса
                mTaskStr = comboBox1.SelectedItem.ToString();
                char symbol = ',';
                mTaskStr = mTaskStr.Substring(1, mTaskStr.IndexOf(symbol) - 1);
            }

            Tsk task = new Tsk();
            task.TaskUpdate(selectRow[0], user, nameBox.Text, deskrBox.Text, taskDoneTimeStr, mTaskStr);
            mf.textBoxShow("Задача изменена!");

            TreeView tree = new TreeView();

            // обновляем старую общую  и новую общую задачу------????????????
            if(!(checkBox1.Checked)){
                tree.updateMainRow(selectRow[7], user);
                tree.updateMainRow(mTaskStr, user);
            } 

            this.Hide();
            checkBoxOn(true);

        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e) {
            TreeView tree = new TreeView();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            if (checkBoxAll.Checked) {
                dic = tree.getAllMainTasks(user);
            } else {
                dic = tree.getMainTasks(user);
            }
            comboSet(dic);
        }

        private void mini_SizeChanged(object sender, EventArgs e) {
            panel1.Height = (int)(Size.Height * 0.9 - 240);
            panel1.Width = (int)(Size.Width * 0.9);
        }

    }
}
