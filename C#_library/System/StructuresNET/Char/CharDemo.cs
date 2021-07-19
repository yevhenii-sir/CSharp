using System;

namespace LearnCSharpOther
{
    static class CharDemo
    {
        static void Main(string[] args)
        {
            string str = "Это простой текст. $23";
            int i;
            for (i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " является");
                if(Char.IsDigit(str[i]))
                    Console.Write(" цифрой");
                if(Char.IsDigit(str[i]))
                    Console.Write(" буквой");
                if(Char.IsLower(str[i]))
                    Console.Write(" строчной");
                if(Char.IsUpper(str[i]))
                    Console.Write(" прописной");
                if(Char.IsSymbol(str[i]))
                    Console.Write(" символьным знаком");
                if(Char.IsSeparator(str[i]))
                    Console.Write(" разделительным");
                if(Char.IsWhiteSpace(str[i]))
                    Console.Write(" пробелом");
                if(Char.IsPunctuation(str[i]))
                    Console.Write(" знаком припинания");
                
                Console.WriteLine();
            }
        }
    }
}

/*

Э является прописной
т является строчной
о является строчной
  является разделительным пробелом
п является строчной
р является строчной
о является строчной
с является строчной
т является строчной
о является строчной
й является строчной
  является разделительным пробелом
т является строчной
е является строчной
к является строчной
с является строчной
т является строчной
. является знаком припинания
  является разделительным пробелом
$ является символьным знаком
2 является цифрой буквой
3 является цифрой буквой

*/
