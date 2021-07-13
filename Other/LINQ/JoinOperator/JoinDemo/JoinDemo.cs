using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class JoinDemo
    {
        static void Main(string[] args)
        {
            Item[] items =
            {
                new Item("Кусачки", 1424),
                new Item("Тиски", 7892),
                new Item("Молоток", 8534),
                new Item("Пила", 6411)
            };

            InStockStatus[] statusList =
            {
                new InStockStatus(1424, true),
                new InStockStatus(7892, false),
                new InStockStatus(8534, true),
                new InStockStatus(6411, true)
            };

            var inStockList = from item in items
                join entry in statusList
                    on item.ItemNumber equals entry.ItemNumber
                select new Temp(item.Name, entry.InStock);

            Console.WriteLine("Товар\t Наличие\n");
            foreach (var temp in inStockList)
                Console.WriteLine($"{temp.Name}\t {temp.InStock}");
        }
    }
}

/*
 
Товар    Наличие

Кусачки  True
Тиски    False
Молоток  True
Пила     True

*/
