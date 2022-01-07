using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Java javaObj = new Java("Java","7-Months",5000,"Full-Time","Off-Site");
            javaObj.Print();
            Console.WriteLine("Course Fee: "+javaObj.GetTotalFee());

            Console.WriteLine();
            Python pythonObj = new Python("Python", "5-Months", 6000, "Part-Time","Off-Site");
            pythonObj.Print();
            Console.WriteLine("Course Fee After Discount: "+pythonObj.GetTotalFee());
            

            Console.WriteLine();
            WebTechnologies webObj = new WebTechnologies("WebTechnologies", "3-Months", 10000, "Part-Time","On-Site");
            webObj.Print();
            Console.WriteLine("Course Fee After Adding 10% Charge: " + webObj.GetTotalFee());
            string s 
            Console.ReadKey();
        }
    }
    
}
