using System;
using System.Reflection;

namespace LearnCSharp
{
    static class ReflectAssembleyDemo2
    {
        static void Main()
        {
            int val;
            Assembly asm = Assembly.LoadFrom("MyClasses.exe");

            Type[] allTypes = asm.GetTypes();

            Type t = allTypes[0]; //Использовать первый обнаруженный класс
            Console.WriteLine("Использовано: " + t.Name);

            ConstructorInfo[] ci = t.GetConstructors();

            ParameterInfo[] cpi = ci[0].GetParameters();
            object reflectOb;

            if (cpi.Length > 0)
            {
                object[] consarg = new object[cpi.Length];

                for (int n = 0; n < cpi.Length; n++)
                {
                    consarg[n] = 10 + n * 20;
                }

                reflectOb = ci[0].Invoke(consarg);
            }
            else reflectOb = ci[0].Invoke(null);
            
            Console.WriteLine("\nВызов методов для объекта reflectOb.");
            Console.WriteLine();

            MethodInfo[] mi = t.GetMethods(BindingFlags.DeclaredOnly | 
                                           BindingFlags.Public | BindingFlags.Instance);

            foreach (var m in mi)
            {
                Console.WriteLine("Вызов метода " + m.Name);

                ParameterInfo[] pi = m.GetParameters();

                switch (pi.Length)
                {
                    case 0:
                        if (m.ReturnType == typeof(int))
                        {
                            val = (int) m.Invoke(reflectOb, null);
                            Console.WriteLine("Результат: " + val);
                        }
                        else if (m.ReturnType == typeof(void))
                            m.Invoke(reflectOb, null);

                        break;
                    case 1:
                        if (pi[0].ParameterType == typeof(int))
                        {
                            object[] arg = new object[1];
                            arg[0] = 14;
                            if ((bool) m.Invoke(reflectOb, arg))
                            {
                                Console.WriteLine("Значение 14 находиться между x и у");
                            }
                            else
                            {
                                Console.WriteLine("Значение 14 не находиться между x и у");
                            }
                        }
                        break;
                    case 2:
                        if (pi[0].ParameterType == typeof(int) &&
                            pi[1].ParameterType == typeof(int))
                        {
                            object[] arg = new object[2];
                            arg[0] = 9;
                            arg[1] = 18;
                            m.Invoke(reflectOb, arg);
                        }
                        else
                        {
                            if (pi[0].ParameterType == typeof(double) &&
                                pi[1].ParameterType == typeof(double))
                            {
                                object[] arg =
                                {
                                    1.12, 23.4
                                };
                                m.Invoke(reflectOb, arg);
                            }
                        }

                        break;
                }
                Console.WriteLine();
            }
        }
    }
}

/* 

Использовано: MyClass
Конструирование класса MyClass(int).

Вызов методов для объекта reflectOb.

Вызов метода Sum
Результат: 20

Вызов метода IsBetween
Значение 14 не находиться между x и у

Вызов метода Set
В методе Set(int, int).Значение x: 9, значение y: 18

Вызов метода Set
В методе Set(double, double).Значение x: 1, значение y: 23

Вызов метода Show
Значение x: 1, значение y: 23

*/
