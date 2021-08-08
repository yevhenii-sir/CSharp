using System;
using System.Threading.Tasks;

namespace LearnCSharpMultiThrProgramming
{
    static class DemoParallelForEach
    {
        private static int[] _data;

        /*static void DisplayData(int v, ParallelLoopState pls)
        {
            if (v < 0) pls.Break();
            Console.WriteLine("Значение " + v); //Не рекомендуется применять writeline в распараллеливаемом цикле
        }*/
        
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен.");

            _data = new int[100_000_000];
            
            for (int i = 0; i < _data.Length; i++) _data[i] = i;

            _data[1000] = -10;

            ParallelLoopResult loopResult = Parallel.ForEach(_data, (v, pls) =>
            {
                if (v < 0) pls.Break();
                Console.WriteLine("Значение " + v);
            });

            if (!loopResult.IsCompleted)
                Console.WriteLine("\nЦикл завершился преждевременно на шаге цикла номер " + loopResult.LowestBreakIteration + '\n');

            Console.WriteLine("Основной поток завершен.");
        }
    }
}
