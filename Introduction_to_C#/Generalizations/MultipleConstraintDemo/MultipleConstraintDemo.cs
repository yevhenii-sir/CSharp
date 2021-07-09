namespace LearnCSharp
{
    static class MultipleConstraintDemo
    {
        static void Main()
        {
            Gen<string, int> obj = new Gen<string, int>("тест", 11);

            //Gen<bool, int> obj2 = new Gen<bool, int>(true, 11); //ошибка, bool не ссылочный тип
        }
    }
}

