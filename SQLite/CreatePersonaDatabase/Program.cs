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
            //Console.Write("Полное имя базы даных которою хотите создать: ");
            Console.Write("Имя файла: ");
            _fileName = Console.ReadLine();
            _fullLocationToFile = @"/home/ainerond/LearnSQLite/Databases/" + _fileName;
            _connectionString = "DataSource = " + _fullLocationToFile + ";";

            /*if (!File.Exists(_fullLocationToFile))
            {
                SQLiteConnection.CreateFile(_fullLocationToFile);
            }
            else
            {
                Console.WriteLine("Файл с таким именем уже существует!");
                return;
            }
            
            CreateTable();
            AddData();*/
            
            UpdateName(3, "Сергей"); //заменить имя персоны у которой id = 3 

            Console.WriteLine("Выход из программы...");
        }

        private static void UpdateName(int id, string replaceByName)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command =
                    new SQLiteCommand("UPDATE Persona SET FirstName = @name WHERE ID == @id", connection);
                command.Parameters.AddWithValue("@name", replaceByName);
                command.Parameters.AddWithValue("@id", id);
                
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Успешно заменено!");
            }
        }

        private static void CreateTable()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                string commandStr = "CREATE TABLE Persona (ID INTEGER PRIMARY KEY, FirstName TEXT, LastName TEXT, Telephone TEXT);";

                SQLiteCommand command = new SQLiteCommand(commandStr, connection);
                connection.Open();
                command.ExecuteNonQuery(); //выполнение запроса
                connection.Close();
            }
        }

        private static void AddData()
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
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

                            SQLiteCommand command = new SQLiteCommand(commandStr, connection);
                            command.Parameters.AddWithValue("@fName", personData[0]);
                            command.Parameters.AddWithValue("@lName", personData[1]);
                            command.Parameters.AddWithValue("@tel", personData[2]);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();

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

Имя файла: Database.db
Успешно заменено!
Выход из программы...

 */

