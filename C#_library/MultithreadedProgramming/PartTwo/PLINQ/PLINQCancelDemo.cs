using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LearnCSharpMultiThrProgramming
{
    static class PLINQCancelDemo
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSrc = new CancellationTokenSource();
            int[] data = new int[100_000_000];

            for (int i = 0; i < data.Length; i++) data[i] = i;

            data[1000] = -1;
            data[14000] = -2;
            data[15000] = -3;
            data[676000] = -4;
            data[8024540] = -5;
            data[9908000] = -6;

            var negatives = from val in data.AsParallel().WithCancellation(cancellationTokenSrc.Token)
                where val < 0
                select val;

            Task cancelTask = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(100);
                cancellationTokenSrc.Cancel();
            });

            try
            {
                foreach (var v in negatives)
                    Console.Write(v + " ");
            }
            catch (OperationCanceledException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                cancelTask.Wait(cancellationTokenSrc.Token);
                cancellationTokenSrc.Dispose();
                cancelTask.Dispose();
            }

            Console.WriteLine();
        }
    }
}
