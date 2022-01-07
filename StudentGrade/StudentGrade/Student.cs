using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrade
{
    class Student : Person
    {
       public Student(string fullName,string id,int numberOfTestCourses,int[] arrayOfTestCourses)
        {
            this.fullName = fullName;
            this.id = id;
            this.numberOfTestCourses = numberOfTestCourses;
            this.arrayOfTestCourses = arrayOfTestCourses;

            
        }
        public char Calculate()
        {
            for(int i=0; i< arrayOfTestCourses.Length;i++)
            {
                average = average + arrayOfTestCourses[i];
            }
            average = average / numberOfTestCourses;

            if (average >= 90 && average <= 100)
            {
                return 'O';
            }
            else if (average >= 80 && average < 90)
            {
                return 'E';
            }
            else if (average >= 70 && average < 80)
            {
                return 'A';
            }
            else if (average >= 55 && average < 70)
            {
                return 'P';
            }
            else if (average >= 40 && average < 55)
            {
                return 'D';
            }
            else
                return 'T';
        }
        public void Display()
        {
            Console.WriteLine("Name: " + fullName);
            Console.WriteLine("Id: " + id);

        }

    }
}
