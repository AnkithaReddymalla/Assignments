using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NetworkLogicArrays
{
    class Network
    {
        public int allLines = 0;
        public int eachLine = 0;
        int[] id;
        string[] source;
        string[] destination;
        string[] date;
        string[] status;
        string[] network;

        public int ReadArraySize()
        {

            FileStream fs = new FileStream("D:\\Assignment1\\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() > 0)
            {
                string myLine = sr.ReadLine();
                if (myLine != "")
                {
                    allLines++;

                }
                else if (myLine == "")
                {
                    eachLine++;
                }

            }
            return allLines / eachLine;
        }
        public void ArraySize(int size)
        {
            int[] id = new int[size];
            string[] source = new string[size];
            string[] destination = new string[size];
            string[] date = new string[size];
            string[] status = new string[size];
            string[] network = new string[size];


        }
        public void ReadNetworkLog()
        {
            FileStream fs = new FileStream("D:\\Assignment1\\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int idx1 = 0;
            int idx2 = 0;
            int idx3 = 0;
            int idx4 = 0;
            int idx5 = 0;
            int idx6 = 0;
            while (sr.Peek() > 0)
            {
                string myLine = sr.ReadLine();
                if (myLine != "")
                {
                        if (myLine.StartsWith("Id"))
                        {
                            string[] array1 = myLine.Split(':');
                            id[idx1++] = Convert.ToInt32(array1[1]);
                        }
                        else if (myLine.StartsWith("Source"))
                        {
                            string[] array2 = myLine.Split(':');
                            source[idx2++] = array2[1];

                        }
                        else if (myLine.StartsWith("Destination"))
                        {
                            string[] array3 = myLine.Split(':');
                            destination[idx3++] = array3[1];
                        }
                        else if (myLine.StartsWith("Date"))
                        {
                            string[] array4 = myLine.Split(':');
                            date[idx4++] = array4[1];
                        }
                        else if (myLine.StartsWith("Status"))
                        {
                            string[] array5 = myLine.Split(':');
                            status[idx5++] = array5[1];
                        }
                        else if (myLine.StartsWith("Network"))
                        {
                            string[] array6 = myLine.Split(':');
                            network[idx6++] = array6[1];
                        }
                    
                }
            }
            
        }
        public void Display()
        {
            for(int i=0; i<id.Length; i++)
            {
                Console.Write(id[i] + " ");
            }
            for (int i = 0; i < source.Length; i++)
            {
                Console.Write(source[i] + " ");
            }
            for (int i = 0; i < destination.Length; i++)
            {
                Console.Write(destination[0] + " ");
            }
            for (int i = 0; i < date.Length; i++)
            {
                Console.Write(date[0] + " ");
            }
            for (int i = 0; i < status.Length; i++)
            {
                Console.Write(status[0] + " ");
            }
            for (int i = 0; i < network.Length; i++)
            {
                Console.Write(network[0] + " ");
            }
        }

    }
}

