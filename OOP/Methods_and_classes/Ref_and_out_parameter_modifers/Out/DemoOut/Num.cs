using System;

namespace BasicLearnCSharp
{
    public class Num
    {
        public bool HasComFactor(int x, int y, out int least, out int greatest)
        {
            int i;
            int max = x < y ? x : y;

            bool first = true;

            least = 1;
            greatest = 1;

            for (i = 2; i < max / 2 + 1; i++)
            {
                if (((y % i) == 0) && ((x % i) == 0))
                {
                    if (first)
                    {
                        least = i;
                        first = false;
                    }

                    greatest = i;
                }
            }

            if (least != 1) return true;
                else return false;
        }

        public void ShowHasComFactor(int x, int y)
        {
            int lcf, gcf;

            if (HasComFactor(x, y, out lcf, out gcf))
            {
                Console.WriteLine($"Наименьший общий множитель чисел {x} и {y} равен: {lcf}");
                Console.WriteLine($"Наибольший общий множитель чисел {x} и {y} равен: {gcf}");
            }
            else
            {
                Console.WriteLine($"Общий множитель у чисел {x} и {y} отсутствует.");
            }
        }
    }
}
