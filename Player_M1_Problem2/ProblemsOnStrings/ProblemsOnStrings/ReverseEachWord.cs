using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsOnStrings
{
    class ReverseEachWord
    {
        public void RevEachWord(string input)
        {
            string[] str = input.Split(' ');
            for (int i = 0; i < str.Length; i++)
            {
                string rev = "";
                for (int j = str[i].Length-1; j >= 0; j-- )
                {
                    rev = rev + str[j];
                }
            
            }
        }
    }
}
