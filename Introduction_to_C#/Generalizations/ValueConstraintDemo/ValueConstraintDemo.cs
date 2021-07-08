namespace LearnCSharp
{
    static class ValueConstraintDemo
    {
        static void Main()
        {
            Test<MyStruct> x = new Test<MyStruct>(new MyStruct());

            Test<int> y = new Test<int>(10);

            //Test<MyClass> z = new Test<MyClass>(new MyClass()); //ошибка, аргумент должен быть типа значения
        }
    }
}

