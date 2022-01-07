using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Add2_Multiply5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listObj = new List<int>();

            Console.Write("Enter Number of List Elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter {0} Element: ", i);
                int v =Convert.ToInt32(Console.ReadLine());
                listObj.Add(v);
            }

            List<int> newObj = new List<int>();
      
            foreach(var v in listObj)
            {
                newObj.Add((v + 2) * 5);
            }
            Console.Write("After Adding 2 and Multiply by 5 New List Elements are: ");
            foreach (var v in newObj)
            {
                Console.Write(v +" ");
            }

            Console.ReadKey();
            
        }
    }
}
