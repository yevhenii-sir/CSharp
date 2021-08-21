using System;
using System.Data.SQLite;
using System.IO;

namespace PracticeSQLite
{
    static class Program
    {
        private static string _fileName, _fullLocationToFile;
        private static SQLiteConnection _connection;
        
        static void Main(string[] args)
        {
            Console.Write("Полное имя базы даных которою хотите создать: ");
            _fileName = Console.ReadLine();
            _fullLocationToFile = @"/home/ainerond/LearnSQLite/Databases/" + _fileName;

            if (!File.Exists(_fullLocationToFile))
            {
                SQLiteConnection.CreateFile(_fullLocationToFile);
            }
            else
            {
                Console.WriteLine("Файл с таким именем уже существует!");
                return;
            }
            
            CreateTable();
            AddData();
            
            Console.WriteLine("Выход из программы...");
        }

        private static void CreateTable()
        {
            using (_connection = new SQLiteConnection("DataSource = " + _fullLocationToFile + ";"))
            {
                string commandStr = "CREATE TABLE Persona (ID INTEGER PRIMARY KEY, FirstName TEXT, LastName TEXT, Telephone TEXT);";

                SQLiteCommand command = new SQLiteCommand(commandStr, _connection);
                _connection.Open();
                command.ExecuteNonQuery(); //выполнение запроса
                _connection.Close();
            }
        }

        private static void AddData()
        {
            try
            {
                using (_connection = new SQLiteConnection("DataSource = " + _fullLocationToFile + ";"))
                {
                    string commandStr, temp;
                    Console.Write("Для выхода напишите !Exit. \nВведите даные персоны (Имя Фамилия Телефон): ");
                    while ((temp = Console.ReadLine()) != "!Exit")
                    {
                        string[] personData = temp.Split();
                        if (personData.Length == 3)
                        {
                            commandStr =
                                "INSERT INTO Persona (FirstName, LastName, Telephone) VALUES (@fName, @lName, @tel)";

                            SQLiteCommand command = new SQLiteCommand(commandStr, _connection);
                            command.Parameters.AddWithValue("@fName", personData[0]);
                            command.Parameters.AddWithValue("@lName", personData[1]);
                            command.Parameters.AddWithValue("@tel", personData[2]);

                            _connection.Open();
                            command.ExecuteNonQuery();
                            _connection.Close();

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
            catch (SQLiteException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}

/*

Полное имя базы даных которою хотите создать: Database.db
Для выхода напишите !Exit. 
Введите даные персоны (Имя Фамилия Телефон): Евгений Сиренко +380457569845
Данные записано!
Введите даные персоны (Имя Фамилия Телефон): Ростислав Ляшенко +380645896541
Данные записано!
Введите даные персоны (Имя Фамилия Телефон): Андрей Бев +380475321475
Данные записано!
Введите даные персоны (Имя Фамилия Телефон): !Exit
Выход из программы...

 */

