using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListOfObjects
{
    class Person
    {
        public string name;
        public int age;
        public override string ToString()
        {
            return name + '-' + age;
        }
    }
}
