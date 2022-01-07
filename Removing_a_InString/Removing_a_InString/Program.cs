using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Removing_a_InString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listObj = new List<string>();

            Console.Write("Enter Number of List Elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter {0} Element: ", i);
                string v = Console.ReadLine();
                listObj.Add(v);
            }
           
            List<string> newObj = new List<string>();
            foreach(var v in listObj)
            {
                string s = "";
                for(int i=0; i<v.Length; i++)
                {
                    if(v[i]!='a')
                    {
                        s = s + v[i];
                    }
                }
                newObj.Add(s);
            }
            Console.Write("After Removing 'a' from Each String: ");
            foreach(var v in newObj)
            {
                Console.Write(v + " ");
            }
            Console.ReadKey();

        }
    }
}
