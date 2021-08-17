using System.Collections;
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

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T obj in _array)
                yield return obj;
        }
    }
}
