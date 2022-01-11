using System;
using PigLatinLibrary;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            PigLatin pigLatin = new PigLatin();
            Console.WriteLine(pigLatin.Translate()); 
        }
    }
}
