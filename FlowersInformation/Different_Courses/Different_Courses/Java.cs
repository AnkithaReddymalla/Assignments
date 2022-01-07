using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Courses
{
    class Java
    {
        public string Name;
        public string Duration;
        public int CourseFee;
        public string Time;
        public string CourseSite;

        public Java(string Name , string Duration , int CourseFee , string Time, string CourseSite)
        {
            this.Name = Name;
            this.Duration = Duration;
            this.CourseFee = CourseFee;
            this.Time = Time;
            this.CourseSite = CourseSite;

        }

        public void Print()
        {
            Console.WriteLine("Course Name: " + Name);
            Console.WriteLine("Course Duration: " + Duration);
            Console.WriteLine("Course Time: " + Time);
            Console.WriteLine("Course Site: " + CourseSite);

        }
        
        public int GetTotalFee()
        {
            return CourseFee;
        }
    }
}
