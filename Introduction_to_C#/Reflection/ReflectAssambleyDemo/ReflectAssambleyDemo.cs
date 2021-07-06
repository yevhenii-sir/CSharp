using System;
using System.Reflection;

namespace LearnCSharp
{
    static class RefclectAssambleyDemo
    {
        static void Main()
        {
            int val;
            
            Assembly asm = Assembly.LoadFrom("MyClasses.dll");

            Type[] allTypes = asm.GetTypes();
            foreach (var temp in allTypes)
                Console.WriteLine("Найдено: " + temp.Name);
            
            Console.WriteLine();

            Type t = allTypes[1]; //использовать MyClass
            Console.WriteLine("Использовано: " + t.Name);

            ConstructorInfo[] ci = t.GetConstructors();

            Console.WriteLine("Доступные конструкторы: ");
            foreach (ConstructorInfo c in ci)
            {
                Console.Write(" " + t.Name + "(");

                ParameterInfo[] pi = c.GetParameters();

                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                    if (i + 1 < pi.Length ) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
            Console.WriteLine();

            int x;
            for (x = 0; x < ci.Length; x++)
            {
                ParameterInfo[] pi = ci[x].GetParameters();

                //поиск конструктора с двумя параметраи и первый параметер должен быть int
                if (pi.Length == 2 && (pi[0].ParameterType == typeof(int))) break;
            }

            if (x == ci.Length)
            {
                Console.WriteLine("Подходящий констуктор не найден!");
                return;
            }
            else Console.WriteLine("Найден конструктор с двумя параметрами.\n");

            object[] consargs = new object[2];
            consargs[0] = 10;
            consargs[1] = 20;
            object reflectOb = ci[x].Invoke(consargs);

            Console.WriteLine("Вызов методов для объекта reflectOb.");
            Console.WriteLine();
            MethodInfo[] mi = t.GetMethods();

            foreach (MethodInfo m in mi)
            {
                ParameterInfo[] pi = m.GetParameters();

                if ((m.Name.CompareTo("Set") == 0) && pi[0].ParameterType == typeof(int))
                {
                    object[] arg = new object[2];
                    arg[0] = 9;
                    arg[1] = 18;
                    m.Invoke(reflectOb, arg);
                }
                else if (m.Name.CompareTo("Set") == 0 && pi[0].ParameterType == typeof(double))
                {
                    object[] arg = new object[2];
                    arg[0] = 1.12;
                    arg[1] = 23.4;
                    m.Invoke(reflectOb, arg);
                }
                else if (m.Name.CompareTo("Sum") == 0)
                {
                    val = (int) m.Invoke(reflectOb, null);
                    Console.WriteLine("Сума равна: " + val);
                }
                else if (m.Name.CompareTo("IsBetween") == 0)
                {
                    object[] arg = new object[1];
                    arg[0] = 14;
                    if ((bool) m.Invoke(reflectOb, arg))
                        Console.WriteLine("Значение 14 находиться между х и у");
                }
                else if (m.Name.CompareTo("Show") == 0)
                {
                    m.Invoke(reflectOb, null);
                }
            }
        }
    }
}

/*

Найдено: AnotherClass
Найдено: MyClass
Найдено: Demo

Использовано: MyClass
Доступные конструкторы: 
 MyClass(Int32 i)
 MyClass(Int32 i, Int32 j)

Найден конструктор с двумя параметрами.

Конструирование класса MyClass(int, int).
Вызов методов для объекта reflectOb.

Сума равна: 30
Значение 14 находиться между х и у
В методе Set(int, int).Значение x: 9, значение y: 18
В методе Set(double, double).Значение x: 1, значение y: 23
Значение x: 1, значение y: 23

*/
