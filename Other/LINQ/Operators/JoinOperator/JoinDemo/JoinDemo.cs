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

            var inStockList = items.Join(statusList,
                k1 => k1.ItemNumber,
                k2 => k2.ItemNumber,
                (k1, k2) => new {k1.Name, k2.InStock});

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
