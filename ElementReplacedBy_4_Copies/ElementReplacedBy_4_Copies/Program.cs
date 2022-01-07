using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementReplacedBy_4_Copies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listObj = new List<string>();

            Console.Write("Enter Number of List Elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                Console.Write("Enter {0} Element: ", i);
                string v = Console.ReadLine();
                listObj.Add(v);
            }
           
            List<string> newObj = new List<string>();
            foreach(var v in listObj)
            {
                newObj.Add(v + v + v + v);
            }
            Console.Write("Output: ");
            foreach (var v in newObj)
            {
                Console.Write(v+" ");
            }
            Console.ReadKey();
        }
    }
}
