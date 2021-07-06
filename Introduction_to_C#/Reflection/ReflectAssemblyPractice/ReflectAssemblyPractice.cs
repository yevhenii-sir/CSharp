using System;
using System.Reflection;

namespace LearnCSharp
{
    static class ReflectAssembleyPractice
    {
        static void Main()
        {
            Assembly asm = Assembly.LoadFrom("BasicLearnCSharp.dll");

            Type[] allTypes = asm.GetTypes();

            Console.Write("Найдено: ");

            for (int i = 0; i < allTypes.Length; i++)
            {
                Console.Write(allTypes[i].Name);
                if (i + 1 < allTypes.Length) Console.Write(", ");
            }
            Console.WriteLine(".");
            
            Console.WriteLine("\nВывести конструкторы и методы каждого класса сборки: ");
            
            foreach (var allType in allTypes)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Класс " + allType.Name);
                
                ConstructorInfo[] ci = allType.GetConstructors();
                
                if (ci.Length == 0) Console.WriteLine("Присутствует только конструктор по умолчанию.");
                else
                {
                    Console.WriteLine("Конструкторы: ");

                    foreach (var c in ci)
                    {
                        Console.Write(" " + allType.Name + " (");

                        ParameterInfo[] pi = c.GetParameters();

                        for (int i = 0; i < pi.Length; i++)
                        {
                            Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                            if (i + 1 < pi.Length) Console.Write(", ");
                        }

                        Console.WriteLine(");");
                    }
                }
                Console.WriteLine();
                
                Console.WriteLine("Методы: ");

                MethodInfo[] mi = allType.GetMethods();
                
                foreach (var m in mi)
                {
                    Console.Write(" " + m.Name + " (");

                    ParameterInfo[] pi = m.GetParameters();

                    for (int i = 0; i < pi.Length; i++)
                    {
                        Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                        if (i + 1 < pi.Length) Console.Write(", ");
                    }

                    Console.WriteLine(");");
                }
            }
        }
    }
}

/* Результат выполнения программы: 

Найдено: CountInst, Factorial, Min, MyClass, NumericFn, Overload, Rect, RefSwap, RevStr, Stack, 
StaticDemo, XYCoord, ColorTriangle, ConveyorControl, FailSoftArray, FailSoftArray2D, PropAcces, 
PwrOfTwo, RangeArray, SimpProp, ConveyorDemo, Rectangle, Triangle, TwoDShape, Nybble, ThreeD.

Вывести конструкторы и методы каждого класса сборки: 
-------------------------------
Класс CountInst
Конструкторы: 
 CountInst ();

Методы: 
 GetCount ();
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс Factorial
Конструкторы: 
 Factorial ();

Методы: 
 FactR (Int32 n);
 FactI (Int32 n);
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс Min
Конструкторы: 
 Min ();

Методы: 
 MinVal (Int32[] nums);
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс MyClass
Конструкторы: 
 MyClass ();

Методы: 
 Factory (Int32 i, Int32 j);
 Show ();
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс NumericFn
Присутствует только конструктор по умолчанию.

Методы: 
 Reciprocal (Double num);
 FracPart (Double num);
 IsEven (Double num);
 IsOdd (Double num);
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс Overload
Конструкторы: 
 Overload ();

Методы: 
 OvlDemo ();
 OvlDemo (Int32 a);
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс Rect
Конструкторы: 
 Rect (Int32 w, Int32 h);

Методы: 
 Area ();
 Show ();
 Enlarge (Int32 factor);
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс RefSwap
Конструкторы: 
 RefSwap (Int32 i, Int32 j);

Методы: 
 Show ();
 Swap (RefSwap& ob1, RefSwap& ob2);
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс RevStr
Конструкторы: 
 RevStr ();

Методы: 
 DisplayRev (String str);
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс Stack
Конструкторы: 
 Stack (Int32 size);
 Stack (Stack ob);

Методы: 
 Push (Char ch);
 Pop ();
 IsFull ();
 IsEmpty ();
 Capacity ();
 GetNum ();
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс StaticDemo
Конструкторы: 
 StaticDemo ();

Методы: 
 ValDiv2 ();
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс XYCoord
Конструкторы: 
 XYCoord ();
 XYCoord (XYCoord obj);
 XYCoord (Int32 i, Int32 j);

Методы: 
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс ColorTriangle
Конструкторы: 
 ColorTriangle (String c, String s, Double w, Double h);

Методы: 
 ShowColor ();
 Area ();
 ShowStyle ();
 get_Name ();
 set_Name (String value);
 get_Width ();
 set_Width (Double value);
 get_Height ();
 set_Height (Double value);
 ShowDim ();
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс ConveyorControl
Конструкторы: 
 ConveyorControl ();

Методы: 
 Conveyor (Action com);
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс FailSoftArray
Конструкторы: 
 FailSoftArray (Int32 size);

Методы: 
 get_Length ();
 get_Error ();
 get_Item (Int32 index);
 set_Item (Int32 index, Int32 value);
 get_Item (Double idx);
 set_Item (Double idx, Int32 value);
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс FailSoftArray2D
Конструкторы: 
 FailSoftArray2D (Int32 r, Int32 c);

Методы: 
 GetRows ();
 GetCols ();
 get_Item (Int32 index1, Int32 index2);
 set_Item (Int32 index1, Int32 index2, Int32 value);
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс PropAcces
Конструкторы: 
 PropAcces ();

Методы: 
 get_MyProp ();
 IncProp ();
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс PwrOfTwo
Конструкторы: 
 PwrOfTwo ();

Методы: 
 get_Item (Int32 index);
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс RangeArray
Конструкторы: 
 RangeArray (Int32 low, Int32 hight);

Методы: 
 get_lowerBound ();
 get_upperBound ();
 get_Length ();
 get_Error ();
 op_Implicit (RangeArray op);
 get_Item (Int32 index);
 set_Item (Int32 index, Int32 value);
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс SimpProp
Конструкторы: 
 SimpProp ();

Методы: 
 get_MyProp ();
 set_MyProp (Int32 value);
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс ConveyorDemo
Присутствует только конструктор по умолчанию.

Методы: 
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс Rectangle
Конструкторы: 
 Rectangle (Double w, Double h);
 Rectangle (Double w);
 Rectangle (Rectangle ob);

Методы: 
 IsSquare ();
 Area ();
 get_Name ();
 set_Name (String value);
 get_Width ();
 set_Width (Double value);
 get_Height ();
 set_Height (Double value);
 ShowDim ();
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс Triangle
Конструкторы: 
 Triangle ();
 Triangle (Double x);
 Triangle (String s, Double w, Double h);
 Triangle (Triangle ob);

Методы: 
 Area ();
 ShowStyle ();
 get_Name ();
 set_Name (String value);
 get_Width ();
 set_Width (Double value);
 get_Height ();
 set_Height (Double value);
 ShowDim ();
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс TwoDShape
Конструкторы: 
 TwoDShape ();
 TwoDShape (Double x, String n);
 TwoDShape (Double w, Double h, String n);
 TwoDShape (TwoDShape ob);

Методы: 
 get_Name ();
 set_Name (String value);
 get_Width ();
 set_Width (Double value);
 get_Height ();
 set_Height (Double value);
 ShowDim ();
 Area ();
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс Nybble
Конструкторы: 
 Nybble ();
 Nybble (Int32 val);

Методы: 
 op_Addition (Nybble op1, Nybble op2);
 op_Addition (Int32 op1, Nybble op2);
 op_Addition (Nybble op1, Int32 op2);
 op_GreaterThan (Nybble op1, Nybble op2);
 op_LessThan (Nybble op1, Nybble op2);
 op_Increment (Nybble op);
 op_Implicit (Int32 op);
 op_Implicit (Nybble op);
 GetVal ();
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();
-------------------------------
Класс ThreeD
Конструкторы: 
 ThreeD ();
 ThreeD (Int32 x, Int32 y, Int32 z);

Методы: 
 op_Implicit (ThreeD op1);
 op_Implicit (ThreeD op);
 op_Implicit (Int32 op);
 op_Addition (ThreeD op1, ThreeD op2);
 Show ();
 GetType ();
 ToString ();
 Equals (Object obj);
 GetHashCode ();

*/
