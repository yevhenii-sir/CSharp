using System;
using System.Data.SQLite;
using System.IO;

namespace PracticeSQLite
{
    static class Program
    {
        private static string _fileName, _fullLocationToFile, _connectionString;

        static void Main(string[] args)
        {
            Console.Write("Полное имя базы даных которою хотите просмотреть: ");
            _fileName = Console.ReadLine();
            _fullLocationToFile = @"/home/ainerond/LearnSQLite/Databases/" + _fileName;
            _connectionString = "DataSource = " + _fullLocationToFile + ";";

            if (!File.Exists(_fullLocationToFile))
            {
                SQLiteConnection.CreateFile(_fullLocationToFile);
            }
            else
            {
                ShowData();
                //Console.WriteLine("Файл с таким именем уже существует!");
                //return;
            }
            
            //CreateTable();
            //AddData();

            Console.WriteLine("Выход из программы...");
        }

        private static void ShowData()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Persona", connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        Console.WriteLine($"{"ID", -3}{"FirstName", -12}{"LastName", -10}Telephone");
                        while (reader.Read())
                        {
                            var id = reader["ID"];
                            var firstName = reader["FirstName"];
                            var lastName = reader["LastName"];
                            var telephone = reader["Telephone"];
                            
                            Console.WriteLine($"{id, -3}{firstName, -12}{lastName, -10}{telephone}");
                        }
                    }
                }
            }
        }

        private static int ExecuteNonQueryCommand(this SQLiteCommand command)
        {
            int number = -1;
            
            try
            {
                using var connection = new SQLiteConnection(_connectionString);
                command.Connection = connection;
                connection.Open();
                number = command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SQLiteException exc)
            {
                Console.WriteLine(exc.Message);
            }

            return number;
        }

        private static void UpdateName(int id, string replaceByName)
        {
            SQLiteCommand command =
                new SQLiteCommand("UPDATE Persona SET FirstName = @name WHERE ID == @id");
            command.Parameters.AddWithValue("@name", replaceByName);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQueryCommand();
            Console.WriteLine("Успешно заменено!");
        }

        private static void CreateTable()
        {
            string commandStr =
                "CREATE TABLE Persona (ID INTEGER PRIMARY KEY, FirstName TEXT, LastName TEXT, Telephone TEXT);";

            SQLiteCommand command = new SQLiteCommand(commandStr);
            command.ExecuteNonQueryCommand();
        }

        private static void AddData()
        {
            string temp;
            Console.Write("Для выхода напишите !Exit. \n" +
                          "Введите даные персоны (Имя Фамилия Телефон): ");
            while ((temp = Console.ReadLine()) != "!Exit")
            {
                string[] personData = temp.Split();
                if (personData.Length == 3)
                {
                    string commandStr = "INSERT INTO Persona (FirstName, LastName, Telephone) VALUES (@fName, @lName, @tel)";

                    SQLiteCommand command = new SQLiteCommand(commandStr);
                    command.Parameters.AddWithValue("@fName", personData[0]);
                    command.Parameters.AddWithValue("@lName", personData[1]);
                    command.Parameters.AddWithValue("@tel", personData[2]);

                    command.ExecuteNonQueryCommand();

                    Console.WriteLine("Данные записано!");
                }
                else
                {
                    Console.WriteLine("Не правильно введены данные");
                }

                Console.Write("Введите даные персоны (Имя Фамилия Телефон): ");
            }
        }
    }
}

/*

Полное имя базы даных которою хотите просмотреть: Database.db
ID FirstName   LastName  Telephone
1  Евгений     Сиренко   +380457569845
2  Ростислав   Ляшенко   +380645896541
3  Сергей      Бев       +380475321475
Выход из программы...

*/
