using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonAppointment
{
  static class Appointment
    {
      
       
        public static string Schedule(List<string> listObj ,string dateTime)
        {
                listObj.Add(dateTime);
                string[] dateTimeArray = dateTime.Split(' ');
                string[] date = dateTimeArray[0].Split('/');
                string[] time = dateTimeArray[1].Split(':');
                return date[2] + ',' + date[0] + ',' + date[1] + ',' + time[0] + ',' + time[1] + ',' + time[2];
           
        }
        public static bool HasPassed(List<string> listObj , string dateTime)
        {
            bool isNotPassed = true;
            foreach(var v in listObj)
            {
                if(dateTime == v)
                {
                    isNotPassed = false;
                }
            }
            return isNotPassed;
        }
        public static bool IsAfternoonAppointment(string dateTime)
        {
            bool isAfternoon = false;
            string[] dateTimeArray = dateTime.Split(' ');
            string[] time = dateTimeArray[1].Split(':');
            if(Convert.ToInt32(time[0]) >= 12 && Convert.ToInt32(time[0]) < 18)
            {
                isAfternoon = true;
            }
            return isAfternoon;
            
        }
        public static void Description(string dateTime)
        {
        
            Console.WriteLine("You have an Appointment on "+dateTime);

        }
  }
}
