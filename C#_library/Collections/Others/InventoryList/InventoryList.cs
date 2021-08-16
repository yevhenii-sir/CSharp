using System;
using System.Collections.Generic;

namespace LearnCSharpCollections
{
    static class InventoryList
    {
        static void Main(string[] args)
        {
            CompInv<Inventory> comp = new CompInv<Inventory>();
            List<Inventory> inv = new List<Inventory>();

            inv.Add(new Inventory("Кусачки", 5.95, 3));
            inv.Add(new Inventory("Отвертки", 8.29, 2));
            inv.Add(new Inventory("Молотки", 3.50, 4));
            inv.Add(new Inventory("Дрели", 19.88, 8));

            Console.WriteLine("Перечень товарных запасов: ");
            foreach (var i in inv)
                Console.WriteLine(" " + i);
            Console.WriteLine();
            
            inv.Sort(comp);
            Console.WriteLine("Перечень товарных запасов: ");
            foreach (var i in inv)
                Console.WriteLine(" " + i);
        }
    }
}

/*

Перечень товарных запасов: 
 Кусачки   Стоимость:  $5.95 Наличие: 3
 Отвертки  Стоимость:  $8.29 Наличие: 2
 Молотки   Стоимость:  $3.50 Наличие: 4
 Дрели     Стоимость: $19.88 Наличие: 8

Перечень товарных запасов: 
 Дрели     Стоимость: $19.88 Наличие: 8
 Кусачки   Стоимость:  $5.95 Наличие: 3
 Молотки   Стоимость:  $3.50 Наличие: 4
 Отвертки  Стоимость:  $8.29 Наличие: 2

*/
