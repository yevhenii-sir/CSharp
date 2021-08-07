using System;
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

            for (int i = 0; i < _data.Length; i++) _data[i] = i;

            Parallel.For(0, _data.Length, MyTransform);

            Console.WriteLine("Основной поток завершен.");
        }
    }
}
