namespace LearnCSharp
{
    public class ArrayUtils
    {
        public static bool CopyInsert<T>(T e, uint idx, T[] src, T[] target)
        {
            if (target.Length < src.Length + 1)
                return false;

            for (int i = 0, j = 0; i < src.Length; i++, j++)
            {
                if (i == idx)
                {
                    target[j] = e;
                    j++;
                }

                target[j] = src[i];
            }

            return true;
        }
    }
}
