using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТТ2 {
    class Tsk {
        public string user;
        string taskName { get; set; }
        string taskDescription { get; set; }
        DateTime taskAddTime { get; set; }
        DateTime taskDoneTime { get; set; }
        int taskMain { get; set; }
        int TaskDone { get; set; }

        DB db = new ТТ2.DB();

        // конструктор
        public Tsk(string User, string name, string deskr, double days, int mTask) {
            user = User;
            taskName = name;
            taskDescription = deskr;
            taskAddTime = DateTime.Now;
            taskDoneTime = taskAddTime.AddDays(days);
            taskMain = mTask;
            TaskDone = 0;

        }

        // перегрузим конструктор
        public Tsk() {
            
        }


        // добавить запись с объекта в базу данных
        public void AddTask() {
            string taskAddTimeStr = taskAddTime.ToString("d");
            string taskDoneTimeStr = taskDoneTime.ToString("d");

            string query = @"INSERT INTO 'MainTable' ('UserName', 'TaskName', 'TaskDeskription', 'TaskAddTime', 'TaskDoneTime', 'TaskDone', 'IsTaskMain')
                            VALUES ('" + user + "', '" + taskName + "', '" + taskDescription + "', '" + taskAddTimeStr + "', '" +
                            taskDoneTimeStr + "', '" + TaskDone + "', '" + taskMain + "')";

            db.DBConnectNonExecute(query);

        }

        // обновить запись в базе данных
        public void TaskUpdate(string Id, string User, string Name, string Deskr, string TaskDoneTime, string TaskMain) {

            int IntTaskMain;
            int.TryParse(TaskMain, out IntTaskMain);


            string query = @"UPDATE MainTable SET TaskName = '" + Name + 
                                      "', TaskDeskription = '" + Deskr +
                                      "', TaskDoneTime = '" + TaskDoneTime +
                                      "', IsTaskMain = '" + IntTaskMain +
                                 "' WHERE UserName = '" + User +
                                 "' AND Id = '" + Id + "'";

            db.DBConnectNonExecute(query);
        }

    }
}
