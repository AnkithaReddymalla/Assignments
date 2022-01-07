using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsOnStrings
{
    class ReverseWordsInString
    {
        public void ReverseWords(string input)
        {
            string revWords = "";
            string[] words = input.Split(' ');
            for (int i = words.Length - 1; i >= 0; i--)
            {
                revWords = revWords + words[i]+" ";
            }
            Console.WriteLine("After Reversing Words In String: " + revWords);
        }
    }
}
