using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace ТТ2 {
    class DB {

        SQLiteConnection connection = new SQLiteConnection("data source = login.db3");

        string createTableQuery = @"CREATE TABLE IF NOT EXISTS
                                      [Login](
                                      [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                      [Name] NVARCHAR(2048) NOT NULL,
                                      [Password] NVARCHAR(2048) NOT NULL)";

        string createMainTable = @"CREATE TABLE IF NOT EXISTS
                                     [MainTable](
                                     [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                     [UserName] NVARCHAR (2048) NOT NULL,
                                     [TaskName] TEXT NOT NULL,
                                     [TaskDeskription] TEXT NOT NULL,
                                     [TaskAddTime] TEXT NOT NULL,
                                     [TaskDoneTime] TEXT,
                                     [TaskDone] INTEGER NOT NULL,
                                     [IsTaskMain] INTEGER NOT NULL)";

        
        // проверка на существование базы данных и таблиц
        public void SearchDB() {
            // Проверка на существование БД и таблицы при загрузке.
            if (!(File.Exists("login.db3"))) {
                SQLiteConnection.CreateFile("login.db3");

                DBConnectNonExecute(createTableQuery);
                DBConnectNonExecute(createMainTable);

                // первая запись в дб чтобы небыло ошибок с базой
                DBConnectStartIncrement();
            }


        }

        // добавление и удаление записи для инкремента c 2
        public void DBConnectStartIncrement() {
            string nol = "0";
            Tsk tsk = new Tsk(nol, nol, nol, 0, 0);
            tsk.AddTask();
            string query = @"DELETE FROM MainTable WHERE UserName = '0' AND Id = '0'";
            DBConnectNonExecute(query);
        }

        // метод для запросов в бд без ответа
        public void DBConnectNonExecute(string query) {

            SQLiteCommand command = new SQLiteCommand(query, connection);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

        }

        // метод для запросов в бд для сравнения
        public bool DBConnectComparison(string query) {

            SQLiteCommand command = new SQLiteCommand(query, connection);

            connection.Open();

            SQLiteDataReader reader = command.ExecuteReader();

            bool hasRows = reader.HasRows;

            reader.Close();
            connection.Close();
            return hasRows;

        }

        // метод возвращающий результат запроса с бд в виде списка списков
        public List<List<string>> DBGetData(string query) {
            SQLiteCommand command = new SQLiteCommand(query, connection);
            connection.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            List<List<string>> recordsList = new List<List<string>>();
            // цикл для вытаскивания данных из ридера
            if (reader.HasRows) {
                while (reader.Read()) {
                    List<string> oneRecord = new List<string>();
                    oneRecord.Add(reader[0].ToString().Trim());
                    oneRecord.Add(reader[1].ToString().Trim());
                    oneRecord.Add(reader[2].ToString().Trim());
                    oneRecord.Add(reader[3].ToString().Trim());
                    oneRecord.Add(reader[4].ToString().Trim());
                    oneRecord.Add(reader[5].ToString().Trim());
                    oneRecord.Add(reader[6].ToString().Trim());
                    oneRecord.Add(reader[7].ToString().Trim());
                    recordsList.Add(oneRecord);

                };
            }
            else {
                reader.Close();
                connection.Close();
                return recordsList;
            }
            reader.Close();
            connection.Close();

            return recordsList;

        }

    }
}
