using System;
using System.Collections;

namespace LearnCSharpCollections
{
    static class InventoryList
    {
        static void Main(string[] args)
        {
            ArrayList inv = new ArrayList();

            inv.Add(new Inventory("Кусачки", 5.95, 3));
            inv.Add(new Inventory("Отвертки", 8.29, 2));
            inv.Add(new Inventory("Молотки", 3.50, 4));
            inv.Add(new Inventory("Дрели", 19.88, 8));

            Console.WriteLine("Перечень товарных хапасов: ");
            foreach (Inventory i in inv)
                Console.WriteLine(" " + i);
        }
    }
}

/*

Перечень товарных хапасов: 
 Кусачки   Стоимость:  $5.95 Наличие: 3
 Отвертки  Стоимость:  $8.29 Наличие: 2
 Молотки   Стоимость:  $3.50 Наличие: 4
 Дрели     Стоимость: $19.88 Наличие: 8

*/
