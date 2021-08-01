using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class SharedRes
    {
        public static int Count = 0;
        public static Mutex Mtx = new Mutex();
    }
}
