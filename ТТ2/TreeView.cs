using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТТ2 {
    class TreeView {
        string query;
        DB db;

        public TreeView() {
            db = new ТТ2.DB();
        
        }

        // просматриваем не выполненные задачи
        public List<List<string>> NotDoneView(string userName) {
            query = @"SELECT * FROM MainTable WHERE UserName = '" + userName + "' AND TaskDone = 0";
            List<List<string>> records = db.DBGetData(query);
            return records;

        }

        // просматриваем все задачи
        public List<List<string>> AllView(string userName) {
            query = @"SELECT * FROM MainTable WHERE UserName = '" + userName + "'";
            List<List<string>> records = db.DBGetData(query);
            return records;
        }

        // просматриваем выполненные задачи
        public List<List<string>> DoneView(string userName) {
            query = @"SELECT * FROM MainTable WHERE UserName = '" + userName + "' AND (TaskDone = 1 OR IsTaskMain = -1)";
            List<List<string>> records = db.DBGetData(query);

            return records;
        }

        // удалить запись в базе данных
        public void DelTask(string userName, string nodeName) {
            string str = @"DELETE FROM MainTable WHERE UserName = '" + userName + "' AND Id = '" + nodeName + "'";
            db.DBConnectNonExecute(str);
            
        }

        // Возврат с базы с одной строки---------------------------------
        public List<string> getRow(string userName, string nodeName) {
            string query = @"SELECT * FROM MainTable WHERE UserName = '" + userName + "' AND Id = '" + nodeName + "'";
            List<List<string>> data = db.DBGetData(query);
            List<string> dataList = new List<string>();
            // перегоняем массив массивов в один список
            foreach (string line in data[0]) {
                dataList.Add(line);
            }
            return dataList;
        }

        // метод для обновления записи в бд
        public void DoneAndCancel(string userName, string nodeName, bool doneOrNot) {
            DateTime nowDate = DateTime.Now;
            string doneDate = nowDate.ToString("d");
            if(doneOrNot){
                query = @"UPDATE MainTAble SET TaskDone = '1', TaskDoneTime = '" + doneDate + 
                    "' WHERE UserName = '" + userName + "' AND Id = '" + nodeName + "'";
            } else {
                query = @"UPDATE MainTAble SET TaskDone = '0' WHERE UserName = '" + userName+
                                                                    "' AND Id = '" + nodeName + "'";
            }

            db.DBConnectNonExecute(query);

        }

        // метод для обновления основной задачи при изменении дочерней --------
        public void updateMainRow(string mainRowId, string userName){
            string query = @"SELECT * FROM MainTable WHERE UserName = '" + userName + "' AND IsTaskMain = '" + mainRowId + "'";
            
            // получили список задач с заданным номером общей задачи
            List<List<string>> list = db.DBGetData(query);
            
            int count = 0;
            string mainKey;
            string isDoneTaskKey = "0";
            // определение количества выполненных задач
            foreach (List<string> line in list){
                if(line[6].Equals("0")){
                    count += 1;
                } 
            }
            // Если есть не выполненые задачи-----------------------------------
            if(count == list.Count){
                mainKey = "1";
            } 
            else if(count > 0 && count < list.Count){
                mainKey = "-1";
            }
            else{
                isDoneTaskKey = "1";
                mainKey = "1";
            }

            query = @"UPDATE MainTable SET TaskDone = '" + isDoneTaskKey + 
                                            "', IsTaskMain = '" + mainKey + 
                                            "' WHERE UserName = '" + userName +
                                            "' AND Id = '" + mainRowId + "'";
            db.DBConnectNonExecute(query);

        }

        // метод для возврата словаря id - название задачи, для не выполненных задач
        public Dictionary<string, string> getMainTasks (string userName) {
            query = @"SELECT * FROM MainTable WHERE (UserName = '" + userName + "' AND TaskDone = 0) AND (IsTaskMain = 1 OR IsTaskMain = -1)";
            List<List<string>> records = db.DBGetData(query);
            Dictionary<string, string> mainList = new Dictionary<string, string>();

            if (records.Count > 0) {
                foreach (List<string> line in records) {
                    string id = line[0];
                    string taskName = line[2];

                    mainList.Add(id, taskName);
                }
            }
            else {
                return mainList;
            }

            return mainList;
        }

        // метод для возврата словаря id - развание задачи, для всех задач
        public Dictionary<string, string> getAllMainTasks(string userName) {
            query = @"SELECT * FROM MainTable WHERE UserName = '" + userName + "' AND (IsTaskMain = 1 OR IsTaskMain = -1)";
            List<List<string>> records = db.DBGetData(query);
            Dictionary<string, string> mainList = new Dictionary<string, string>();

            if (records.Count > 0) {
                foreach (List<string> line in records) {
                    string id = line[0];
                    string taskName = line[2];

                    mainList.Add(id, taskName);
                }
            }
            else {
                return mainList;
            }

            return mainList;
        }

    }
}
