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
    public partial class mainForm : Form {
        public mainForm() {
            InitializeComponent();
        }

        public string user;

        // выход
        private void button6_Click(object sender, EventArgs e) {
            Close();
        }

        // добавить задание
        private void addButton_Click(object sender, EventArgs e) {
            AddTask();
        }

        // статистика
        private void statButton_Click(object sender, EventArgs e) {
            // метод для статистики
            getStat();
        }

        // получение данных родительской формы при загрузке-------------
        private void mainForm_Load(object sender, EventArgs e) {
            LoginForm loginForm = (LoginForm)this.Owner;
            user = loginForm.user;
            ViewNotDone();

        }

        // метод для отображения статистики
        public void getStat() {
            TreeView tree = new TreeView();
            // получаем список всех задач
            List<List<string>> all = tree.AllView(user);
            int countMain = 0;
            int countDone = 0;
            int countNotDone = 0;
            foreach(List<string> line in all) {
                if (line[6].Equals("0")) {
                    countNotDone += 1;
                }
                else {
                    countDone += 1;
                }
            }
            foreach(List<string> line in all) {
                if(line[7].Equals("1") || line[7].Equals("-1")) {
                    countMain += 1;
                }
            }

            textBox1.ForeColor = Color.DarkGreen;
            textBox1.Text = String.Format(@"Всего задач:  
{0}

Общих:  
{1}

Внутренних задач:  
{2}

Выполнено:  
{3}

Ожидают выполнения:  {4}", all.Count, countMain, all.Count - countMain, countDone, countNotDone);


        }

        // событие при нажатии на дерево---------------------------------
        private void MainTree_AfterSelect(object sender, TreeViewEventArgs e) {

            // проверка выбрана ли задача
            TreeNode node = MainTree.SelectedNode;
            if (node == null) {
                textBox1.ForeColor = Color.DarkRed;
                textBox1.Text = "Задача не выбрана, изменение не возможно!";
                return;
            }
            else {
                TreeView tree = new TreeView();
                List<string> row = tree.getRow(user, node.Name);
                textBox1.ForeColor = Color.DarkBlue;
                textBox1.Text = String.Format(@"Название задачи:  
{0}

Описание задачи:   
{1}

Дата добавления:   
{2}

Дата выполнения:   
{3}", row[2], row[3], row[4], row[5]);
            }
        }


        // перезагрузка приложения----------------------------------------
        private void restart_Click(object sender, EventArgs e) {
            Application.Restart();
        }

        // экран шовер---------------------------------------------------
        public void textBoxShow (string showText) {
            textBox1.Text = showText;
        }
        //----------------------------------------------------------------
        private void viewNotDoneButton_Click(object sender, EventArgs e) {
            ViewNotDone();
            textBox1.ForeColor = Color.DarkBlue;
            textBox1.Text = "Отображены не выполненные задачи!";
        }

        private void viewDoneButton_Click(object sender, EventArgs e) {
            ViewDone();
            textBox1.ForeColor = Color.DarkBlue;
            textBox1.Text = "Отображены выполненные задачи!";
        }

        private void viewAllButton_Click(object sender, EventArgs e) {
            ViewAll();
            textBox1.ForeColor = Color.DarkBlue;
            textBox1.Text = "Отображены все задачи!";
        }

        //удаление задачи--------------------------------------------------
        private void delButton_Click(object sender, EventArgs e) {
            DelTask();
            ViewAll();   
        }

        // выполнить задачу -------------------------------------------------
        private void doneButton_Click(object sender, EventArgs e) {
            doneTask(true);
            ViewAll();
        }

        private void cancelDoneButton_Click(object sender, EventArgs e) {
            doneTask(false);
            ViewAll();
        }

        // изменение задачи ------------------------------------------------
        private void changeButton_Click(object sender, EventArgs e) {
            ChangeTask();
            ViewNotDone();
        }

        // выполнить задачу или не выполнить задачу--------------------------
        public void doneTask(bool doneOrNot){
            // проверка выбрана ли задача
            TreeNode node = MainTree.SelectedNode;
            if(node == null) {
                textBox1.ForeColor = Color.DarkRed;
                textBox1.Text = "Задача не выбрана!";
                return;
            } else {
                Tsk tsk = new Tsk();
                TreeView tree = new TreeView();
                // получаем выделенную строку
                List<string> row = tree.getRow(user, node.Name);

                if(row[7].Equals("-1") || row[7].Equals("1")){
                    textBox1.ForeColor = Color.DarkRed;
                    textBox1.Text = "Невозможно выполнить или отправить на доработку общую задачу! Она изменяется автоматически при изменении дочерних!";
                    return;
                }

                // обновляем выделенную строку
                
                tree.DoneAndCancel(user, node.Name, doneOrNot);

                // обновляем общую задачу
                tree.updateMainRow(row[7], user);

            }

        }



        // метод изменения задачи -----------------------------------------
        public void ChangeTask() {
            // проверка выбрана ли задача
            TreeNode node = MainTree.SelectedNode;
            if(node == null) {
                textBox1.ForeColor = Color.DarkRed;
                textBox1.Text = "Задача не выбрана, изменение не возможно!";
                return;
            } else {

                mini dtf = new mini();
                dtf.Owner = this;

                // проверка на дочерние узлы
                if (node.GetNodeCount(true) > 0) {
                    dtf.checkBoxOn(false);
                }

                // меняем кнопки (изменить - добавить)
                dtf.changeButtonVisible(true);
                dtf.addButtonVisible(false);

                TreeView tree = new TreeView();
                List<string> oneRow = tree.getRow(user, node.Name);

                dtf.SetNameBox(oneRow[2]);
                dtf.SetDeskrBox(oneRow[3]);

                Dictionary<string, string> comboList = new Dictionary<string, string>();

                if (oneRow[6].Equals("1")) {
                    comboList = tree.getAllMainTasks(user);
                    dtf.checkBoxStateChange(true);
                } else {
                    comboList = tree.getMainTasks(user);
                }
                //поиск индекса в комбобоксе, по которому к нему можно будет обратиться
                int count = 0;

                // проверка на основное задание
                if (oneRow[7].Equals("1") || oneRow[7].Equals("-1")) {
                    dtf.checkBoxStateChange(true);
                    dtf.comboSet(comboList);
                    dtf.comboVisible(false);
   
                }
                else {

                    foreach (KeyValuePair<string, string> line in comboList) {
                        if (oneRow[7].Equals(line.Key)) {
                            break;
                        }
                        else {
                            count += 1;
                        }
                    }

                    // добавление основных заданий в комбобокс
                    dtf.checkBoxStateChange(false);
                    dtf.comboSet(comboList);
                    dtf.comboBoxSelectedChange(count);
                    // передадим выделенную строку
                    
                }

                dtf.selectRow = oneRow;
                dtf.ShowDialog(this);
            }


        }

        // удалить задачу------------------------------------------------
        public void DelTask() {

            TreeNode node = MainTree.SelectedNode;
            // проверка выбрана ли задача
            if (node == null) {
                textBox1.ForeColor = Color.DarkRed;
                textBox1.Text = "Задача не выбрана, удаление не возможно!";
                return;
            } else {
                int myNodeCount = node.GetNodeCount(true);
                // проверка на входящие элементы
                if (myNodeCount > 0) {
                    textBox1.ForeColor = Color.DarkRed;
                    textBox1.Text = "Не возможно удалить задачу, так как есть внтуренние элементы.";
                    return;

                } else {

                    TreeView tree = new TreeView();
                    tree.DelTask(user, node.Name);
                    textBox1.ForeColor = Color.DarkBlue;
                    textBox1.Text = "Задача удалена!";

                    // обновляем старую общую задачу
                    // возможно ошибка, выдрать номер общей задачи
                    tree.updateMainRow(node.ToString(), user); 

                }
            }
        }

        // отобразить выполненные--------------------------------------------
        public void ViewDone() {

            TreeView tree = new TreeView();
            List<List<string>> treeList = tree.DoneView(user);

            treeCreate(treeList);
        }

        // отобразить все----------------------------------------------------
        public void ViewAll() {

            TreeView tree = new TreeView();
            List<List<string>> treeList = tree.AllView(user);

            treeCreate(treeList);
        }

        //отобразить не выполенные-------------------------------------------
        public void ViewNotDone() {

            TreeView tree = new TreeView();
            List<List<string>> treeList = tree.NotDoneView(user);

            treeCreate(treeList);
        }


        // метод добавления задачи  ------------------------------------------
        private void AddTask() {
            mini dtf = new mini();
            dtf.Owner = this;
            dtf.addButtonVisible(true);
            dtf.changeButtonVisible(false);

            TreeView tree = new TreeView();

            // добавление основных заданий в комбобокс
            Dictionary<string, string> comboList = tree.getMainTasks(user);

            if (comboList.Count > 0) {
                dtf.checkBoxStateChange(false);
                dtf.comboSet(comboList);
            }
            else {
                dtf.checkBoxStateChange(true);
            }
            dtf.ShowDialog(this);
        }


        // метод составления дерева -----------------------------------------
        public void treeCreate(List<List<string>> treeList) {
            MainTree.Nodes.Clear();
            // иконки для дерева
            ImageList myImageList = new ImageList();
            myImageList.Images.Add(Image.FromFile("source/cross.png"));
            myImageList.Images.Add(Image.FromFile("source/galochka.png"));
            myImageList.Images.Add(Image.FromFile("source/done.ico"));
            myImageList.Images.Add(Image.FromFile("source/notDone.png"));

            MainTree.ImageList = myImageList;

            if (treeList.Count > 0) {

                foreach (List<string> line in treeList) {

                    if (line[7].Equals("1") || line[7].Equals("-1")) {
                        // если isMainTask = 1  или -1 создаем родительский узел + if Для рисунка

                        if (line[6].Equals("0")) {
                            MainTree.Nodes.Add(line[0], line[2], 3);
                            // чтобы картинка не менялась
                            MainTree.Nodes[line[0]].SelectedImageIndex = 3;

                        }
                        else {
                            MainTree.Nodes.Add(line[0], line[2], 2);
                            // Смена цвета нужной записи
                            MainTree.Nodes[ line[0]].ForeColor = Color.Gray;
                            // чтобы картинка не менялась
                            MainTree.Nodes[line[0]].SelectedImageIndex = 2;
                        }
                    }
                    if(treeList.Count == 0){
                        textBox1.ForeColor = Color.DarkBlue;
                        textBox1.Text = "Все задания выполнены!";
                    }
                }

                // присваиеваем дочерний процесс родительскому узлу
                foreach (List<string> childLine in treeList) {

                    if (childLine[7].Equals("1") || childLine[7].Equals("-1")) {

                    }
                    else {
                        if (childLine[6].Equals("0")) {
                            MainTree.Nodes[childLine[7]].Nodes.Add(childLine[0], childLine[2], 0);
                            // чтобы картинка не менялась
                            MainTree.Nodes[childLine[7]].Nodes[childLine[0]].SelectedImageIndex = 0;
                        }
                        else {
                            MainTree.Nodes[childLine[7]].Nodes.Add(childLine[0], childLine[2], 1);
                            // Смена цвета нужной записи
                            MainTree.Nodes[childLine[7]].Nodes[childLine[0]].ForeColor = Color.Gray;
                            // чтобы картинка не менялась
                            MainTree.Nodes[childLine[7]].Nodes[childLine[0]].SelectedImageIndex = 1;
                        }
                    }
                        
                }


            }
        }

        private void mainForm_SizeChanged(object sender, EventArgs e) {
            panel3.Height = (int)(Size.Height * 0.65);
            panel3.Width = (int)(Size.Width * 0.40);

            panel4.Height = (int)(Size.Height * 0.65);
            panel4.Width = (int)(Size.Width * 0.40);
        }
    }
}
