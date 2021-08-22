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
            Console.Write("Полное имя базы даных которою хотите создать: ");
            _fileName = Console.ReadLine();
            _fullLocationToFile = @"/home/ainerond/LearnSQLite/Databases/" + _fileName;
            _connectionString = "DataSource = " + _fullLocationToFile + ";";

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
            string commandStr, temp;
            Console.Write("Для выхода напишите !Exit. \nВведите даные персоны (Имя Фамилия Телефон): ");
            while ((temp = Console.ReadLine()) != "!Exit")
            {
                string[] personData = temp.Split();
                if (personData.Length == 3)
                {
                    commandStr =
                        "INSERT INTO Persona (FirstName, LastName, Telephone) VALUES (@fName, @lName, @tel)";

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
