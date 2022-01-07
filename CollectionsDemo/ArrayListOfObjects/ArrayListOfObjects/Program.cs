using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ArrayList al = new ArrayList();
            int num = 1;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter {0} Person Name:",num);
                string name = Console.ReadLine();

                Console.Write("Enter {0} Person Age:",num++);
                int age = Convert.ToInt32(Console.ReadLine());
                al.Add(new Person() { name = name, age = age });
            }
            Console.WriteLine("Name - Age");
            foreach(Person p in al)
            {
                Console.WriteLine(p.ToString());
            }
            

            Console.ReadKey();

        }
    }
}
