#define RELEASE

using System;

static class Test2
{
    static void Main(string[] args)
    {
#if EXPERIMENTAL
        Console.WriteLine("Компилируется для эксперементальной версии.");
#elif RELEASE
        Console.WriteLine("Компилируется для отдельной версии.");
#else
        Console.WriteLine("Компилируется для внутренего тестирования")
#endif

#if TRIAL && !RELEASE
        Console.WriteLine("Пробная версия.");
#endif
        Console.WriteLine("Присутствует во всех версиях.");
    }
}
