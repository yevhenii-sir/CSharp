using System;
using System.Linq;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;

namespace LearnCSharpMultiThrProgramming
{
    static class PracticeParallelLinq
    {
        static void Main(string[] args)
        {
            var randomizerString = RandomizerFactory.GetRandomizer(new FieldOptionsText()); //RandomDataGenerator.Net package
            string[] rndTextArray = new string[5000];

            for (int i = 0; i < rndTextArray.Length; i++) rndTextArray[i] = randomizerString.Generate();
            
            (rndTextArray.AsParallel().Where(s => s.Contains('(') && s.Contains(')'))).ForAll(Console.WriteLine); //найти строки которые включают в себя заданые символы
        }
    }
}
