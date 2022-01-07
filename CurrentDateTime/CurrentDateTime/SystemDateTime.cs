using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CurrentDateTime
{
    class SystemDateTime
    {
        public void GetDateTime()
        {
            FileStream fileStreamObj = new FileStream("D:\\Test\\MyFile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fileStreamObj);
            sw.WriteLine(DateTime.Now);
        }
    }
}
