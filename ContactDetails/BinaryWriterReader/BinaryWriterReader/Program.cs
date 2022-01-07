using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryWriterReader
{
    class Program
    {
        //BinaryWriter and BinaryReader are inbuilt classes which are present in System.IO NameSpace.
        //These classes are used to read and write primitive data types  and strings.
        /*BinaryWriter :-The BinaryWriter class is used to write binary data to a stream.
                         A BinaryWriter object is created by passing a FileStream object to its constructor.
         *BinaryReader :-The BinaryReader class is used to read binary data from a file.
                         A BinaryReader is created by psing a FileStream object to its constructor.*/
        /*BinaryWriter VS StreamWriter :-BinaryWriter is for primitive data types(BinaryWriter writes the in-memory binary representation of the value)
                                         StreamWriter is for text(The StreamWriter writes the ASCII representation)*/
                         
        
        static void Main(string[] args)
        {
            int i = 5;
            double d = 3.14;
            char ch = 'a';

            FileStream fs1 = new FileStream("D:\\Test\\BinaryWriterReader.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter br1 = new BinaryWriter(fs1);
            br1.Write(i);
            br1.Write(d);
            br1.Write(ch);
            br1.Close();
            fs1.Close();

           FileStream fs2 = new FileStream("D:\\Test\\BinaryWriterReader.txt", FileMode.Open, FileAccess.Read);
            BinaryReader br2 = new BinaryReader(fs2);
            int a = br2.ReadInt32();
            double b = br2.ReadDouble();
            char c = br2.ReadChar();
            Console.WriteLine("Integer Value: " + a);
            Console.WriteLine("Double Value: " + b);
            Console.WriteLine("Character: '{0}'",c);
            br2.Close();
            fs2.Close();
            Console.ReadKey();
        }
    }
}
