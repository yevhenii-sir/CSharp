using System;

namespace LearnCSharpOther
{
    static class ConcatDemo2
    {
        static void Main(string[] args)
        {
            string result = String.Concat("значение равно " + 19);
            Console.WriteLine("Result: " + result);

            result = String.Concat("hello ", 88, " ", 20.0, " ", false, " ", 23.45M);
            Console.WriteLine("Result: " + result);

            MyClass me = new MyClass();
            result = String.Concat(me.GetType().Name, " текущий счет равен ", MyClass.Count);
            Console.WriteLine("Result: " + result);
        }
    }
}

/*

Result: value is 19
Result: hello 88 20 False 23,45
Result: MyClass текущий счет равен 1

*/
