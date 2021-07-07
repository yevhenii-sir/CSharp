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
            Console.Write("Примечание: ");

            Type tRemAtt = typeof(RemarkAttribute);
            RemarkAttribute ra = (RemarkAttribute) Attribute.GetCustomAttribute(t, tRemAtt);
            
            Console.WriteLine(ra.Remark);
        }
    }
}

/*

Атрибуты в классе UseAttrib: RemarkAttribute
Примечание: В этом классе используеться атрибут.

*/
