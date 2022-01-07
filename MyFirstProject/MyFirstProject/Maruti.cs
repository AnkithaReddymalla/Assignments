using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Maruti
    {
       public void GetDetails()
        {
            // CONVERTING ONE DATA TYPE TO ANOTHER

            //int - string
            int value1 = 100;
            string value2 = value1.ToString();

            //int - object
            int price = 500;
            object value3 =price ;

            //string - object
            string name = "ankitha";
            object value4 = name;

            // double - string
            double percent = 5.8;
            string value5 = percent.ToString();

            // string - object and object - string
            string college = "aurora";
            object value6 = college;
            string value7 = value6.ToString();

            //int - object and object - int
            int mark = 100;
            object obj = mark;
            int remark = Convert.ToInt32(obj);

            //object - double
            double value8 = Convert.ToDouble(obj);

            //character - object and object - character
            char gender = 'M';
            object replace = gender;
            char recognization = Convert.ToChar(replace);










            //Console.WriteLine("My name is ankitha");
        }
    }
}
