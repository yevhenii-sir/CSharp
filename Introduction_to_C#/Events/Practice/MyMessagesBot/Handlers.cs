using System;

namespace Exercise
{
    static class Handlers
    {
        public static void CommandHandler(object source, MyMessArgs args)
        {
            if (args.Message[0] == '!')
            {
                switch (args.Message)
                {
                    case "!Start" : 
                        Console.WriteLine("Бот запущен.");
                        break;
                    case "!Clear" :
                        Console.Clear();
                        break;
                    case "!Help" :
                        Console.WriteLine("Существуют команды: \n" +
                                          "!Start - вывод сообщения про запуск бота;\n" +
                                          "!Clear - очистка экрана;\n" +
                                          "!Help - помощь;\n" +
                                          "!Exit - выход из преложения.");
                        break;
                    case "!Exit" : 
                        Console.WriteLine("Выход из преложения.");
                        break;
                    default:
                        Console.WriteLine("Команды не найдено!");
                        break;
                }
            }
        }

        public static void StandardMessHandler(object source, MyMessArgs args)
        {
            if (args.Message[0] != '!')
            {
                Console.WriteLine("Ответ бота: " + ReverceStr(args.Message));
            }
        }

        private static string ReverceStr(string s)
        {
            string temp = "";
            int i;
            
            for (i = s.Length - 1; i >= 0; i--)
            {
                temp += s[i];
            }

            return temp;
        }
    }
}
