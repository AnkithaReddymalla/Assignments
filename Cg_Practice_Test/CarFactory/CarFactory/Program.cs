using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Speed: ");
            int speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SuccessRate: "+AssemblyLine.SuccessRate(speed));
            Console.WriteLine("Production Rate Per Hour: "+AssemblyLine.ProductionRatePerHour(speed));
            Console.WriteLine("The Number of Working Items Produced Per Minute: "+AssemblyLine.WorkingItemsPerMinute(speed));
            Console.ReadKey();

        }
    }
}
