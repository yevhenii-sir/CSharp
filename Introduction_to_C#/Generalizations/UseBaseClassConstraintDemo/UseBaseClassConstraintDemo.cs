using System;

namespace LearnCSharp
{
    class EmailFriend {}
    
    static class UseBaseClassConstraintDemo
    {
        static void Main()
        {
            PhoneList<Friend> plist = new PhoneList<Friend>();
            plist.Add(new Friend("Том", "555-1234", true));
            plist.Add(new Friend("Гари", "555-6756", true));
            plist.Add(new Friend("мМатт", "555-9254", false));

            try
            {
                Friend frnd = plist.FindByName("Гари");
                
                Console.Write(frnd.Name + " " + frnd.Number);
                if (frnd.IsWorkNumber)
                {
                    Console.WriteLine(" (рабочий)");
                }
                else Console.WriteLine();
            }
            catch (NotFoundException)
            {
                Console.WriteLine("Не найдено!");
            }

            PhoneList<Supplier> plist2 = new PhoneList<Supplier>();
            plist2.Add(new Supplier("Фирма Global Hardware", "555-8834"));
            plist2.Add(new Supplier("Агенство Computer Warehouse", "555-9256"));
            plist2.Add(new Supplier("Компания NetworkCity", "555-2564"));

            try
            {
                Supplier sp = plist2.FindByNumber("555-2564");
                
                Console.WriteLine(sp.Name + " " + sp.Number);
            }
            catch (NotFoundException)
            {
                Console.WriteLine("Не найдено!");
            }

            //PhoneList<EmailFriend> plist3 = new PhoneList<EmailFriend>(); //ошибка, нет наследования от PhoneNumber
        }
    }
}

/*
 
Гари 555-6756 (рабочий)
Компания NetworkCity 555-2564

*/
