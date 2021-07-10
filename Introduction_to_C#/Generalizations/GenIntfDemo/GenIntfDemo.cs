using System;

namespace LearnCSharp
{
    public static class GenIntfDemo
    {
        static int IntPlusTwo(int v)
        {
            return v + 2;
        }

        private static double DoublePlusTwo(double v)
        {
            return v + 2.0;
        }

        static ThreeD ThreeDPlusTwo(ThreeD v)
        {
            if (v == null) return new ThreeD(0, 0, 0);
            else return new ThreeD(v.x + 2, v.y + 2, v.z + 2);
        }
        
        public static void Main()
        {
            ByTows<int> intBT = new ByTows<int>(IntPlusTwo);
            
            for (int i = 0; i < 5; i++) 
                Console.Write(intBT.GetNext()  + " ");
            Console.WriteLine();

            ByTows<double> dblBT = new ByTows<double>(DoublePlusTwo);
            dblBT.SetStart(11.4);

            for (int i = 0; i < 5; i++)
                Console.Write(dblBT.GetNext() + " ");
            
            Console.WriteLine();

            ByTows<ThreeD> ThrDBT = new ByTows<ThreeD>(ThreeDPlusTwo);
            ThreeD coord;

            for (int i = 0; i < 5; i++)
            {
                coord = ThrDBT.GetNext();
                Console.Write(coord.x + "," + coord.y + "," + coord.z + "; ");
            }
            
            Console.WriteLine();
        }
    }
}
