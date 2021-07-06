using System;
using System.Reflection;

namespace LearnCSharp
{
    static class InvokeMethDemo
    {
        static void Main(string[] args)
        {
            Type t = typeof(MyClass);
            MyClass reflectOb = new MyClass(10, 20);
            int val;
            
            Console.WriteLine("Вызов методов, определенных в " +
                              "клaссе " + t.Name);
            
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
 
