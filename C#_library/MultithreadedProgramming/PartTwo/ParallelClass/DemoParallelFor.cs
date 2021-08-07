using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LearnCSharpMultiThrProgramming
{
    static class DemoParallelFor
    {
        private static int[] _data;

        static void MyTransform(int i)
        {
            _data[i] = _data[i] / 10;

            if (_data[i] < 10000) _data[i] = 0;
            if (_data[i] > 10000 & _data[i] < 20000) _data[i] = 100;
            if (_data[i] > 20000 & _data[i] < 30000) _data[i] = 200;
            if (_data[i] > 30000) _data[i] = 300;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен.");

            _data = new int[100_000_000];
            
            Stopwatch sw = Stopwatch.StartNew();
            Parallel.For(0, _data.Length, (i) => _data[i] = i);
            sw.Stop();
            Console.WriteLine("Параллельно выполняемый цикл инициализации: {0} секунд.", sw.Elapsed.TotalSeconds);
            sw.Reset();
            
            sw.Start();
            for (int i = 0; i < _data.Length; i++) _data[i] = i;
            sw.Stop();
            Console.WriteLine("Последовательно выполняемый цикл инициализации: {0} секунд.", sw.Elapsed.TotalSeconds);
            sw.Reset();
            Console.WriteLine();

            sw.Start();
            Parallel.For(0, _data.Length, MyTransform);
            sw.Stop();
            Console.WriteLine("Параллельно выполняемый цикл преобразования: {0} секунд.", sw.Elapsed.TotalSeconds);
            sw.Reset();

            sw.Start();
            for (int i = 0; i < _data.Length; i++) MyTransform(i);
            sw.Stop();
            Console.WriteLine("Последовательно выполняемый цикл преобразования: {0} секунд.", sw.Elapsed.TotalSeconds);

            Console.WriteLine("Основной поток завершен.");
        }
    }
}

/*
Основной поток запущен.
Параллельно выполняемый цикл инициализации: 0.1505218 секунд.
Последовательно выполняемый цикл инициализации: 0.2017253 секунд.

Параллельно выполняемый цикл преобразования: 0.4245728 секунд.
Последовательно выполняемый цикл преобразования: 1.1605602 секунд.
Основной поток завершен.
*/
