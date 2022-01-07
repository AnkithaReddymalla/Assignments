using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLogicArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Network nw = new Network();
            int size = nw.ReadArraySize();
            nw.ArraySize(size);
            nw.ReadNetworkLog();
            nw.Display();
            Console.ReadKey();
        }
    }
}
