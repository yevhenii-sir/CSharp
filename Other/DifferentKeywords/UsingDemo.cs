using System.IO;

namespace LearnCSharpOther
{
    static class UsingDemo
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("text.txt");
                using (sr)
                {
                    // ..
                } //Поток автоматически закрывается
            }
            catch (IOException e)
            {
                // ...
            }

            try
            {
                using (StreamReader sr = new StreamReader("text.txt"))
                {
                    // ...
                }
            }
            catch (IOException e)
            {
                // ...
            }
        }
    }
}

