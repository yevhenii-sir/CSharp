using System;
using System.Collections;

namespace LearnCSharpCollections
{
    static class QueueDemo
    {
        static void ShowEnq(Queue q, int a)
        {
            q.Enqueue(a);
            Console.WriteLine("Поместить в очередь: Enqueue(" + a + ")");
            
            Console.Write("Содержиое очереди: ");
            foreach (var i in q)
                Console.Write(i + " ");
            Console.WriteLine('\n');
        }

        static void ShowDeq(Queue q)
        {
            Console.Write("Извлечь из очереди: Dequeue -> ");
            int? a = (int?)q.Dequeue();
            
            Console.WriteLine(a);
            
            Console.WriteLine("Содержимое стека: " + String.Join(" ", q.ToArray()));
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            Queue q = new Queue();

            ShowEnq(q, 22);
            ShowEnq(q, 65);
            ShowEnq(q, 91);
            ShowDeq(q);
            ShowDeq(q);
            ShowDeq(q);

            try
            {
                ShowDeq(q);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Очередь пуста.");
            }
        }
    }
}

/*

Поместить в очередь: Enqueue(22)
Содержиое очереди: 22 

Поместить в очередь: Enqueue(65)
Содержиое очереди: 22 65 

Поместить в очередь: Enqueue(91)
Содержиое очереди: 22 65 91 

Извлечь из очереди: Dequeue -> 22
Содержимое стека: 65 91

Извлечь из очереди: Dequeue -> 65
Содержимое стека: 91

Извлечь из очереди: Dequeue -> 91
Содержимое стека: 

Извлечь из очереди: Dequeue -> Очередь пуста.


*/
