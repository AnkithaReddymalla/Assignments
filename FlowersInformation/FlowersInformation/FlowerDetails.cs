using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlowersInformation
{
    class FlowerDetails
    {
        public void GetInformation()
        {
            FileStream fileStreamObj = new FileStream("D:\\Assignment1\\flowersInfo.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fileStreamObj);
            while(sr.Peek()>0)
            {
                string readMyLine = sr.ReadLine();
                Console.WriteLine(readMyLine);
            }
        }
        

    }
}
