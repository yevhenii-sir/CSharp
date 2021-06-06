using System;

namespace BasicLearnCSharp
{
    static class RefSwapDemo
    {
        static void Main(string[] args)
        {
            RefSwap x = new RefSwap(1, 2);
            RefSwap y = new RefSwap(3, 4);
            
            Console.Write("x до вызова: ");
            x.Show();
            
            Console.Write("y до вызова: ");
            y.Show();
            
            Console.WriteLine();
            
            x.Swap(ref x, ref y);
            
            Console.Write("x после вызова: ");
            x.Show();
            
            Console.Write("y после вызова: ");
            y.Show();
        }
    }
}
