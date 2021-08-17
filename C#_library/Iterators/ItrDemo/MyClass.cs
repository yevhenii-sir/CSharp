using System.Collections;

namespace LearnCSharpCollections
{
    public class MyClass
    {
        private char[] _chrs = { 'A', 'B', 'C', 'D' };

        public IEnumerator GetEnumerator()
        {
            foreach (var chr in _chrs)
            {
                yield return chr;
            }
        }
    }
}
