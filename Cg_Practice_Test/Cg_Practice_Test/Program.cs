using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cg_Practice_Test
{
    class Program
    {
        static void Main(string[] args)
        {
			IList<Person> p = new List<Person>();
			p.Add(new Person { Name = "Aarya", Address = "A2101", Age = 69 });
			p.Add(new Person { Name = "Daniel", Address = "D104", Age = 40 });
			p.Add(new Person { Name = "Ira", Address = "H801", Age = 25 });
			p.Add(new Person { Name = "Jennifer", Address = "I1704", Age = 33 });
			PersonImplementation personImplementation = new PersonImplementation();
			Console.WriteLine("Name & Address:"+personImplementation.GetName(p));
			Console.WriteLine("Average Age: "+personImplementation.Average(p));
			Console.WriteLine("Maximum Age: "+personImplementation.Max(p));
			Console.ReadKey();
		}
	}
}
	