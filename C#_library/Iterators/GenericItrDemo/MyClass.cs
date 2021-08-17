using System.Collections.Generic;

namespace LearnCSharpCollections
{
    public class MyClass<T>
    {
        private T[] _array;

        public MyClass(T[] array)
        {
            _array = array;
        }

        public IEnumerable<T> MyItr(int startIndex, int count)
        {
            for (int i = startIndex; i < startIndex + count; i++)
                yield return _array[i];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T obj in _array)
                yield return obj;
        }
    }
}
