using System;
using System.Collections;

namespace LearnCSharpCollections
{
    static class BADemo
    {
        public static void ShowBits(string rem, BitArray bits)
        {
            Console.WriteLine(rem);
            for (int i = 0; i < bits.Count; i++)
                Console.Write("{0, -6}", bits[i]);
            Console.WriteLine('\n');
        }
        
        static void Main(string[] args)
        {
            BitArray ba = new BitArray(8);
            byte[] b = { 67 };

            BitArray ba2 = new BitArray(b);
            
            ShowBits("Исходное содержимое коллекции ba:", ba);
            
            ba = ba.Not();
            ShowBits("Содержимое коллекции bа после логической операции NOT:", ba);
            ShowBits("Содержимое коллекции bа2:", ba2);
            
            BitArray ba3 = ba.Xor(ba2);
            ShowBits("Результат логической операции ba XOR bа2:", ba3);
        }
    }
}

/*
 
Исходное содержимое коллекции ba:
False False False False False False False False 

Содержимое коллекции bа после логической операции NOT:
True  True  True  True  True  True  True  True  

Содержимое коллекции bа2:
True  True  False False False False True  False 

Результат логической операции ba XOR bа2:
False False True  True  True  True  False True 

 */

