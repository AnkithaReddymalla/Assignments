using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonAppointment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listObj = new List<string>();
            listObj.Add("9/16/2012 9:30:00 AM");
            listObj.Add("9/16/2012 13:30:00 PM");
            listObj.Add("9/17/2012 10:30:00 AM ");
            listObj.Add("9/18/2012 12:30:00 PM");
            listObj.Add("9/19/2012 17:30:00 PM");

            Console.Write("Enter Your Appointment Date and Time: ");
            string dateTime = Console.ReadLine();
            bool check = Appointment.HasPassed(listObj, dateTime);
            if (check == false)
            {
                Console.WriteLine("With this Date and Time One Appointment is Already Scheduled, Enter Anothe Time or Date");
            }
            else
            {
                Console.WriteLine("new DateTime({0})", Appointment.Schedule(listObj, dateTime));
                Appointment.Description(dateTime);
            }
            Console.ReadKey();



        }
    }
}
