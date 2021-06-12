namespace BasicLearnCSharp
{
    public static class NumericFn
    {
        public static double Reciprocal(double num)
        {
            return 1 / num;
        }
        
        public static double FracPart(double num)
        {
            return num - (int) num;
        }

        public static bool IsEven(double num)
        {
            return (num % 2)== 0 ? true : false;
        }

        public static bool IsOdd(double num)
        {
            return !IsEven(num);
        }
    }
}
