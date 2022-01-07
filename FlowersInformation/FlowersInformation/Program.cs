using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerDetails flowerDetailsObj = new FlowerDetails();
            flowerDetailsObj.GetInformation();
            Console.ReadKey();
        }
    }
}
