namespace LearnCSharp
{
    static class NukedConstraintDemo
    {
        static void Main()
        {
            Gen<A, B> x = new Gen<A, B>();

            //Gen<B, A> x = new Gen<B, A>(); //ошибка, второй аргумент должен наследовать первый или быть таким самым
        }
    }
}

