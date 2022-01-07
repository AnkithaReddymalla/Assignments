using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Student Roll Number: ");
            int rollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Course Name: ");
            string course = Console.ReadLine();
            
            Console.Write("Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*************** STUDENT INFORMATION ***************");
            Student studentObj = new Student(rollNo, name,course);
            studentObj.Payment(amount);
            studentObj.Print();
            Console.ReadKey();
        }
    }
}
