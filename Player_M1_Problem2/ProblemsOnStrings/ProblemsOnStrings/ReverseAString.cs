using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsOnStrings
{
    class ReverseAString
    {
        public string Reverse(string s1)
        {
            string rev = "";
            for (int i = 0; i < s1.Length; i++)
            {
                rev = s1[i] + rev;
            }
            return rev;


          /*for (int i = s1.Length-1; i >= 0; i-- )
            {
                rev = rev + s1[i];
            }
            return rev;*/
        }
    }
}
