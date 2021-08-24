/*
 * Fibonacci Sequence - Enter a number and have the program generate
 * the Fibonacci sequence to that number or to the Nth number.
 */

using System;

namespace LearnCSharpOther
{
    static class FibonacciSequence
    {
        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите размер последовательности для вывода: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}) {Fibonacci(i), -10}");
                if ((i % 4) == 0) Console.WriteLine();
            }
        }
    }
}

/*

Введите размер последовательности для вывода: 45
Результат: 
1) 1         2) 1         3) 2         4) 3         
5) 5         6) 8         7) 13        8) 21        
9) 34        10) 55        11) 89        12) 144       
13) 233       14) 377       15) 610       16) 987       
17) 1597      18) 2584      19) 4181      20) 6765      
21) 10946     22) 17711     23) 28657     24) 46368     
25) 75025     26) 121393    27) 196418    28) 317811    
29) 514229    30) 832040    31) 1346269   32) 2178309   
33) 3524578   34) 5702887   35) 9227465   36) 14930352  
37) 24157817  38) 39088169  39) 63245986  40) 102334155 
41) 165580141 42) 267914296 43) 433494437 44) 701408733 
45) 1134903170

*/
