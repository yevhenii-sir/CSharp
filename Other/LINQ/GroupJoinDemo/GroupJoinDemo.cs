using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class GroupJoinDemo
    {
        static void Main(string[] args)
        {
            string[] travelTypes =
            {
                "Воздушный",
                "Морской",
                "Наземный",
                "Речной"
            };

            Transport[] transports =
            {
                new Transport("велосипед", "Наземный"),
                new Transport("аэростат", "Воздушный"),
                new Transport("лодка", "Речной"),
                new Transport("самолет", "Воздушный"),
                new Transport("каноэ", "Речной"),
                new Transport("биплан", "Воздушный"),
                new Transport("автомашина", "Наземный"),
                new Transport("судно", "Морской"),
                new Transport("поезд", "Наземный")
            };

            var byHow = from how in travelTypes
                join trans in transports
                    on how equals trans.How
                    into lst
                select new {How = how, Tlist = lst};

            foreach (var t in byHow)
            {
                Console.WriteLine($"К категории <{t.How} транспорт> относиться: ");
                foreach (var m in t.Tlist) 
                    Console.WriteLine(" " + m.Name);
                
                Console.WriteLine();
            }
        }
    }
}

/*
 
К категории <Воздушный транспорт> относиться: 
 аэростат
 самолет
 биплан

К категории <Морской транспорт> относиться: 
 судно

К категории <Наземный транспорт> относиться: 
 велосипед
 автомашина
 поезд

К категории <Речной транспорт> относиться: 
 лодка
 каноэ

*/
