using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assignment2
{
    class Student
    {
        int rollNo;
        string name;
        string course;
        int totalFee;
        int dueAmount;
        int feePaidSoFar;
        public Student(int rollNo,string name,string course)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.course = course;

        }
        public void Payment(int amount)
        {
            if (course == "c#")
            {
                totalFee = 2000;
                dueAmount = totalFee - amount;

            }
            else if (course == "asp.net")
            {
                totalFee = 3000;
                dueAmount = totalFee - amount;
            }
            feePaidSoFar = amount;



        }
        public void Print()
        {
            
             Console.WriteLine("Student RollNumber is: " + rollNo);
             Console.WriteLine("Student Name is: " + name);
             Console.WriteLine("Course Name: " + course);
             Console.WriteLine("Total Fee: " + totalFee);
             Console.WriteLine("Fee Paid So Far: " + feePaidSoFar );
             Console.WriteLine("Due Amount: " + dueAmount);
        }
    }
}
