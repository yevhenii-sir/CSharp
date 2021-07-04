using System;

namespace Exercise
{
    static class MyMessagesBot
    {
        static void Main(string[] args)
        {
            MyMessageEventBot botClient = new MyMessageEventBot();

            botClient.OnMessage += Handlers.CommandHandler;
            botClient.OnMessage += Handlers.StandardMessHandler;

            string str;
            
            do
            {
                Console.Write("Введите сообщение или команду: ");
                str = Console.ReadLine();
                botClient.OnMessageEvent(str);
                Console.WriteLine("----------------------");
            } while (str != "!Exit");
        }
    }
}


/*
 
Введите сообщение или команду: !Start
Бот запущен.
----------------------
Введите сообщение или команду: !Help
Существуют команды: 
!Start - вывод сообщения про запуск бота;
!Clear - очистка экрана;
!Help - помощь;
!Exit - выход из преложения.
----------------------
Введите сообщение или команду: Привет
Ответ бота: тевирП
----------------------
Введите сообщение или команду: !Привет
Команды не найдено!
----------------------
Введите сообщение или команду: !Exit
Выход из преложения.
----------------------

*/