using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandiling
{
    class DoctorFile
    {
        public void GetDoctorInformation()
        {
            FileStream fileStreamObj = new FileStream("D:\\Test\\MyFile.txt", FileMode.Create, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fileStreamObj);

            sw.WriteLine("Multi Speciality Hospital");

            Console.Write("Enter the Hospital Name: ");
            string hospitalName = Console.ReadLine();

            Console.Write("Enter the Doctor Name: ");
            string doctorName = Console.ReadLine();

            Console.Write("Enter the Specialization: ");
            string specializedIn = Console.ReadLine();

            Console.Write("Enter the Doctor Fee: ");
            int fee = Convert.ToInt32(Console.ReadLine());

            sw.WriteLine("Hospital Name is: " + hospitalName);
            sw.WriteLine("Doctor Name is: " + doctorName);
            sw.WriteLine("Specialized in: " + specializedIn);
            sw.WriteLine("Doctor Fee is: " + fee);

            sw.Close();
            fileStreamObj.Close();
            Console.WriteLine("Information Saved Successfully");
        
        }
    }
}

               