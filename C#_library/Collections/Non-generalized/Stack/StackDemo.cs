using System;
using System.Collections;

namespace LearnCSharpCollections
{
    static class StackDemo
    {
        static void ShowPush(Stack st, int a)
        {
            st.Push(a);
            Console.WriteLine("Поместить в стек: Push(" + a + ")");
            
            Console.Write("Содержиое стека: ");
            foreach (var i in st)
                Console.Write(i + " ");
            Console.WriteLine('\n');
        }

        static void ShowPop(Stack st)
        {
            Console.Write("Извлечь из стека: Pop -> ");
            int? a = (int?)st.Pop();
            
            Console.WriteLine(a);
            
            Console.WriteLine("Содержимое стека: " + String.Join(" ", st.ToArray()));
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            Stack st = new Stack();

            ShowPush(st, 22);
            ShowPush(st, 65);
            ShowPush(st, 91);
            ShowPop(st);
            ShowPop(st);
            ShowPop(st);

            try
            {
                ShowPop(st);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Стек пуст.");
            }
        }
    }
}

/*

Поместить в стек: Push(22)
Содержиое стека: 22 

Поместить в стек: Push(65)
Содержиое стека: 65 22 

Поместить в стек: Push(91)
Содержиое стека: 91 65 22 

Извлечь из стека: Pop -> 91
Содержимое стека: 65 22

Извлечь из стека: Pop -> 65
Содержимое стека: 22

Извлечь из стека: Pop -> 22
Содержимое стека: 

Извлечь из стека: Pop -> Стек пуст.

*/
