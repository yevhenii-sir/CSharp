using System;

namespace LearnCSharpOther
{
    static class CloneDemo
    {
        static void Main(string[] args)
        {
            Test ob1 = new Test(10, 20);
            ob1.Show("ob1");

            Console.WriteLine("Сделать объект ob2 копией объекта ob1.");
            Test ob2 = (Test) ob1.Clone();
            ob2.Show("ob2");
            
            Console.WriteLine("Изменить значение оb1.о.а на 99, " +
                              "а значение оb1.b - на 88.");

            ob1.o.a = 99;
            ob1.b = 88;
            
            ob1.Show("ob1");
            ob2.Show("ob2");
        }
    }
}

/*

Значения объекта ob1: o.a: 10, b: 20
Сделать объект ob2 копией объекта ob1.
Значения объекта ob2: o.a: 10, b: 20
Изменить значение оb1.о.а на 99, а значение оb1.b - на 88.
Значения объекта ob1: o.a: 99, b: 88
Значения объекта ob2: o.a: 10, b: 20

*/
