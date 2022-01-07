using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cg_Practice_Test
{
    class PersonImplementation
    {
		int listCount;
		public string GetName(IList<Person> person)
		{
			string str = " ";
			foreach (var item in person)
			{
				str = str + item.Name + " " + item.Address + " ";
			}
			return str;
		}

		public double Average(IList<Person> person)
		{
			int count = 0;
			int avg = 0;
			foreach (var item in person)
			{
				avg = avg + item.Age;
				count++;

			}
			avg = avg / count;
			listCount = count;
			return avg;


		}

		public int Max(IList<Person> person)
		{
			int maxAge = person[0].Age;
			for (int i = 1; i < listCount; i++)
				if (maxAge < person[i].Age)
				{
					maxAge = person[i].Age;
				}
			return maxAge;


		}
	}
}
