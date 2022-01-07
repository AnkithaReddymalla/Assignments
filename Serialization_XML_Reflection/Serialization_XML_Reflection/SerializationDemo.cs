using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Serialization_XML_Reflection
{
    [Serializable]
    class Demo
    {
        public string ApplicantName { get; set; }
        public int ApplicantId { get; set; }
    }
    class SerializationDemo
    {
        public static void Serialization()
        {
            Demo d = new Demo();
            d.ApplicantName = "Ankitha";
            d.ApplicantId = 101;
            FileStream fs = new FileStream(@"D:\Test\Binary.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, d);
            fs.Close();

        }
        public static void DeSerialization()
        {
            FileStream fs = new FileStream("D:\\Test\\Binary.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Demo deSerializedObj = (Demo) bf.Deserialize(fs);
            Console.WriteLine($"ApplicantName - {deSerializedObj.ApplicantName} ------- ApplicantId - {deSerializedObj.ApplicantId}");
            fs.Close();
        }
        public static void XmlSerialization(AddressDetails details)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AddressDetails));
            using (TextWriter writer = new StreamWriter("D:\\Test\\XmlData.xml"))
            {
                serializer.Serialize(writer, details);
            }
        }
        public static void XmlDeSerialization(string xmlpath)
        {
            XmlSerializer deSerializer = new XmlSerializer(typeof(AddressDetails));
            TextReader reader = new StreamReader(xmlpath);
            object obj = deSerializer.Deserialize(reader);
            AddressDetails XmlData = (AddressDetails)obj;
            Console.WriteLine("City Name: "+XmlData.City);
            Console.WriteLine("Street Name: "+XmlData.StreetName);
            reader.Close();
        }
    }
    public class AddressDetails
    {
        public int HouseNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        private string PoAddress { get; set; }
    }
}

