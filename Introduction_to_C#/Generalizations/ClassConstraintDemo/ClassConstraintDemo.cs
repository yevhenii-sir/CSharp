namespace LearnCSharp
{
    static class ClassConstraintDemo
    {
        static void Main()
        {
            Test<MyClass> x = new Test<MyClass>();

            //Test<int> y = new Test<int>(); //ошибка, аргумент должен быть ссылочным
        }
    }
}

