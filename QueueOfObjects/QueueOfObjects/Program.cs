using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
           Queue qu = new Queue();
            int num = 1;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter {0} Person Name:", num);
                string name = Console.ReadLine();

                Console.Write("Enter {0} Person Age:", num++);
                int age = Convert.ToInt32(Console.ReadLine());
                qu.Enqueue(new Person() { name = name, age = age });
            }
            Console.WriteLine("Name - Age");
            foreach (Person p in qu)
            {
                Console.WriteLine(p.ToString());
            }
            Console.ReadKey();

        }
    }
}
