#define EXPERIMENTAL

using System;

static class Test
{
    static void Main(string[] args)
    {
#if EXPERIMENTAL
        Console.WriteLine("Компилируется для эксперементальной версии.");
#endif
        Console.WriteLine("Присутствует во всех версиях.");
        
    }
}
