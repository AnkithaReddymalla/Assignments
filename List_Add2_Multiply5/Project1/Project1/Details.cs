using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Details : Laptop
    {
        public void GetInformation()
        {
            Console.WriteLine("Laptop Name: "+name);
            Console.WriteLine("Laptop Price: "+price);
            Console.WriteLine("Processor Name: "+processor);
            Console.WriteLine("RAM: "+ram);
            Console.WriteLine("Hard Drive Name: "+hardDrive);
        }
    }
}
