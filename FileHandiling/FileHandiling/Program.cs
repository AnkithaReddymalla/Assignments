using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandiling
{
    class Program
    {
        static void Main(string[] args)
        {
            DoctorFile doctorFileObj = new DoctorFile();
            doctorFileObj.GetDoctorInformation();
            Console.ReadKey();
        }
    }
}
