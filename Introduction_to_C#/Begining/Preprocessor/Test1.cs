#define EXPERIMENTAL
#define TRIAL

using System;

static class Test
{
    static void Main(string[] args)
    {
#if EXPERIMENTAL
        Console.WriteLine("Компилируется для эксперементальной версии.");
#else
        Console.WriteLine("Компилируется для отдельной версии.");
#endif

#if EXPERIMENTAL && TRIAL
        Console.WriteLine("Проверка пробной эксперементальной версии.");
#else
        Console.WriteLine("Это не пробная експерементальная версия.")
#endif
        Console.WriteLine("Присутствует во всех версиях.");
    }
}
