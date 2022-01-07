using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_XML_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // SerializationDemo.Serialization();
            //SerializationDemo.DeSerialization();

            AddressDetails addressDetails = new AddressDetails();
            addressDetails.HouseNo = 44;
            addressDetails.City = "Adilabad";
            addressDetails.StreetName = "Ramnagar";
            SerializationDemo.XmlSerialization(addressDetails);
            SerializationDemo.XmlDeSerialization("D:\\Test\\XmlData.xml");

            Console.ReadKey();






        }
    }
}
