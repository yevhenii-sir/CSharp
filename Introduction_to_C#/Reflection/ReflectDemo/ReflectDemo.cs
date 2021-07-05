using System;
using System.Reflection;

namespace LearnCSharp
{
    static class ReflectDemo
    {
        static void Main(string[] args)
        {
            Type t = typeof(MyClass);
            
            Console.WriteLine("Анализ методов, определенных в " +
                              "клaссе " + t.Name);
            
            Console.WriteLine();
            
            Console.WriteLine("Поддерживаемые методы: ");

            MethodInfo[] mi = t.GetMethods(BindingFlags.DeclaredOnly | 
                                           BindingFlags.Instance | BindingFlags.Public);

            foreach (MethodInfo m in mi)
            {
                Console.Write(" " + m.ReturnType.Name + " " + m.Name + "(");

                ParameterInfo[] pi = m.GetParameters();
                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                    if (i + 1 < pi.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
                
                Console.WriteLine();
            }
        }
    }
}

