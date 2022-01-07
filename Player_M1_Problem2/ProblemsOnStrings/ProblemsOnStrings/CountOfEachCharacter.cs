using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsOnStrings
{
    class CountOfEachCharacter
    {
        public void Count(string s1)
        {
            string s2 = "";
            for(int i = 0; i < s1.Length; i++)
            {
                char ch = s1[i];
                if (ch != ' ')
                {
                    if (s2.IndexOf(ch) == -1)
                    {
                        s2 = s2 + ch;
                    }
                }
            }
            for(int i = 0; i < s2.Length; i++)
            {
                 int count = 0;
                 for(int j=0; j<s1.Length; j++)
                 {
                    if (s2[i] == s1[j])
                     {
                        count++;
                     }

                 }
                 Console.WriteLine("{0} - {1}",s2[i],count);
            }

        }
    }
}
