using System;

namespace LearnCSharpLINQ
{
    static class ExtDemo
    {
        static void Main(string[] args)
        {
            double val = 8.0;
            string str = "Alpha Beta Gamma";
            
            Console.WriteLine("Обратная величина {0} равна {1}", val, val.Reciprocal());
            
            Console.WriteLine(str + " после смены регистра: " + str.RevCase());
            
            Console.WriteLine("Результат вызова метода val.AbsDivide(-2): " + val.AbsDivideBy(-2));
            
            Console.WriteLine("\nТакже возможен такой вызов " +
                              "\"Hello World!\".RevCase(), результат: " + "Hello World!".RevCase());
        }
    }
}

/*

Обратная величина 8 равна 0,125
Alpha Beta Gamma после смены регистра: aLPHA bETA gAMMA
Результат вызова метода val.AbsDivide(-2): 4

Также возможен такой вызов "Hello World!".RevCase(), результат: hELLO wORLD!

 */

