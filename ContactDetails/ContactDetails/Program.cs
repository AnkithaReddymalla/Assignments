using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacts contacts = new Contacts();
            contacts.GetContactDetails();
            Console.ReadKey();
        }
    }
}
