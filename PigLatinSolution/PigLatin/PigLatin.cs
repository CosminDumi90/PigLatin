using System;
using System.Text;

namespace PigLatinLibrary
{
 
    public class PigLatin
    {
        private string[] vowels = {"a","e","i","o","u"};
        private string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z"};

       

        public string Translate()
        {
            Console.Write("Please insert the word you wish to be translated: ");
            string word = Console.ReadLine();
           
            for (int i = 0; i < vowels.Length; i++)
            {
                if (word.StartsWith(vowels[i]))
                {
                    var translate = new StringBuilder();
                    translate.Append($"{word}AY");
                    return translate.ToString();
                }else
                {
                    for (int j = 0; j < consonants.Length; j++)
                    {
                        if (word.StartsWith(consonants[j]))
                        {
                            var translate = new StringBuilder();
                            translate.Append($"{word.Substring(1)}{word.Substring(0,1)}AY");
                            return translate.ToString();
                        }
                    }
                }
            }
            return "";
        }
         
        
    }
}
