using System.Collections;

namespace LearnCSharpCollections
{
    public class MyClass: IEnumerator, IEnumerable
    {
        private char[] _chrs = { 'A', 'B', 'C', 'D' };
        private int _idx = -1;

        public IEnumerator GetEnumerator() => this;

        public object Current => _chrs[_idx];

        public bool MoveNext()
        {
            if (_idx == _chrs.Length - 1)
            {
                Reset();
                return false;
            }

            _idx++;
            return true;
        }

        public void Reset()
        {
            _idx = -1;
        }
    }
}
