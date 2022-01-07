using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackOfObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            int num = 1;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter {0} Person Name:", num);
                string name = Console.ReadLine();

                Console.Write("Enter {0} Person Age:", num++);
                int age = Convert.ToInt32(Console.ReadLine());
                st.Push(new Person() { name = name, age = age });
            }
            Console.WriteLine("Name - Age");
            foreach (Person p in st)
            {
                Console.WriteLine(p.ToString());
            }
            Console.ReadKey();

        }
    }
}
