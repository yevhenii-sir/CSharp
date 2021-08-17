using System.Collections;

namespace LearnCSharpCollections
{
    public class MyClass
    {
        private char _ch = 'A';

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 26; i++)
            {
                if (i == 10) yield break;
                yield return (char)(_ch + i);
            }
        }
    }
}
