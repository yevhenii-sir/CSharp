using System.Collections;

namespace LearnCSharpCollections
{
    public class MyClass
    {
        private char _ch = 'A';
        
        public IEnumerable MyItr(int end)
        {
            for (int i = 0; i < end; i++)
                yield return (char)(_ch + i);
        }

        public IEnumerable MyItr(int begin, int end)
        {
            for (int i = begin; i < end; i++)
                yield return (char)(_ch + i);
        }
    }
}
