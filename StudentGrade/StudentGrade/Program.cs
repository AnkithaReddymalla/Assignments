using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Full Name: ");
            string fullName = Console.ReadLine();

            Console.Write("Id: ");
            string id = Console.ReadLine();

            Console.Write("Number Of Test Courses: ");
            int numberOfTestCourses = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Elements Of Test Course Array: ");
            int[] arrayOfTestCourses = new int[numberOfTestCourses];
            for(int i=0; i < numberOfTestCourses; i++)
            { 
                arrayOfTestCourses[i] = int.Parse(Console.ReadLine());
            }

            Student s1 = new Student(fullName,id, numberOfTestCourses, arrayOfTestCourses);
            s1.Display();
            Console.WriteLine("Grade: " + s1.Calculate());
            Console.ReadKey();






        }
    }
}
