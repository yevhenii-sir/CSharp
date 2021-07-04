#define EXPERIMENTAL
#define TRIAL

using System;

static class Test
{
    static void Main(string[] args)
    {
#if EXPERIMENTAL
        Console.WriteLine("Компилируется для эксперементальной версии.");
#endif

#if EXPERIMENTAL && TRIAL
        Console.WriteLine("Проверка пробной эксперементальной версии.");
#endif
        Console.WriteLine("Присутствует во всех версиях.");
        
    }
}
