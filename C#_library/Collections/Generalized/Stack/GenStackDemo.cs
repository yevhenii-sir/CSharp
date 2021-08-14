using System;
using System.Collections.Generic;

namespace LearnCSharpCollections
{
    static class GenStackDemo
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            
            st.Push("один");
            st.Push("два");
            st.Push("три");
            st.Push("четыре");
            st.Push("пять");

            while (st.Count > 0)
            {
                string str = st.Pop();
                Console.Write(str + " ");
            }
            
            Console.WriteLine();
        }
    }
} 
