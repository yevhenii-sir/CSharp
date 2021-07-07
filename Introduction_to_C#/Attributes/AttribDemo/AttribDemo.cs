using System;

namespace LearnCSharp
{
    static class AttribDemo
    {
        static void Main()
        {
            Type t = typeof(UseAttrib);
            
            Console.Write("Атрибуты в классе " + t.Name + ": ");
            object[] attribs = t.GetCustomAttributes(false);
            foreach (var o in attribs)
            {
                Console.WriteLine(o);
            }

            Type tRemAtt = typeof(RemarkAttribute);
            RemarkAttribute ra = (RemarkAttribute) Attribute.GetCustomAttribute(t, tRemAtt);
            
            Console.Write("Примечание: ");
            Console.WriteLine(ra.Remark);
            
            Console.Write("Дополнение: ");
            Console.WriteLine(ra.Supplement);
            
            Console.WriteLine("Приоритет: " + ra.Priotity);
        }
    }
}

/*

Атрибуты в классе UseAttrib: RemarkAttribute
Примечание: В этом классе используеться атрибут.
Дополнение: Это дополнительная информация.
Приоритет: 10

*/
