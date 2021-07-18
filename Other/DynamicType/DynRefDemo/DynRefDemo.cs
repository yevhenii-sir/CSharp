using System;
using System.Reflection;

namespace LearnCSharpOther
{
    static class DynRefDemo
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom("DivBy.dll");
            Type[] all = asm.GetTypes();

            int i;
            for (i = 0; i < all.Length; i++)
                if(all[i].Name == "DivBy") break;

            if (i == all.Length)
            {
                Console.WriteLine("Класс DivBy не найден в сборке.");
                return;
            }

            Type t = all[i];

            ConstructorInfo[] ci = t.GetConstructors();
            
            int j;
            for (j = 0; j < ci.Length; j++)
                if (ci[j].GetParameters().Length == 0) break;

            if (j == ci.Length)
            {
                Console.WriteLine("Используемый по умолчанию конструктор не найден.");
                return;
            }
            
            dynamic obj = ci[j].Invoke(null);
            
            Console.WriteLine("Доступные методы: ");
            MethodInfo[] mi = t.GetMethods(BindingFlags.DeclaredOnly | 
                                           BindingFlags.Instance | 
                                           BindingFlags.Public);

            foreach (var methodInfo in mi)
            {
                Console.Write("   " + methodInfo.ReturnType.Name + " " + methodInfo.Name + "(");

                ParameterInfo[] pi = methodInfo.GetParameters();
                
                for (int k = 0; k < pi.Length; k++)
                {
                    Console.Write(pi[k].ParameterType.Name + " " + pi[k].Name);
                    if (k + 1 < pi.Length) Console.Write(", ");
                }
                Console.WriteLine(");");
            }
            Console.WriteLine();

            Console.WriteLine(obj.IsDivBy(15, 3) ? "15 делится цело на 3." : "15 HE делится цело на 3.");
            
            Console.WriteLine(obj.IsEven(9) ? "9 четное число" : "9 НЕ четное число.");
        }
    }
}

/*

Доступные методы: 
   Boolean IsDivBy(Int32 a, Int32 b);
   Boolean IsEven(Int32 a);

15 делится цело на 3.
9 НЕ четное число.

*/
