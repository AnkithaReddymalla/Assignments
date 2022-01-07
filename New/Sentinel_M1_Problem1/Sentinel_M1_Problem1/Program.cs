using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentinel_M1_Problem1
{
    class Program
    {
        public string SENTINEL = "~";

        public string JoinIt(string[] input)
        {
            string s = " ";
            for(int i=0; i<input.Length; i++)
            {
                s = s + input[i] + SENTINEL;
            }
            return s;

        }

        public string[] SplitIt(string input)
        {
            string[] str = input.Split(' ');
            return str;

        }

        public StringBuilder Reverse(string input)
        {
            StringBuilder sb = new StringBuilder();
            string[] str = input.Split(' ');
            for(int i=str.Length - 1; i>=0; i--)
            {
                sb.Append(str[i]+" ");
            }
            return sb;

        }

        public string PadLeft(string input, int n , char a)
        {
            int len = input.Length;
            if(len == n)
            {
                return input;
            }
            else
            {
                int required = n - len;
                string s = " ";
                for(int i=1; i<=required; i++)
                {
                    s = s + a;
                }
                s = s + input;
                return s;
            }

        }

        static void Main(string[] args)
        {
            Program p = new Program();

            //Creating String Array
            Console.Write("Enter Size of String Array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] s = new string[size];
            int k = 1;
            Console.WriteLine("Enter Elements of String Array: ");
            for (int i=0; i<s.Length; i++)
            {
                Console.Write("Enter Element {0}: ",k++);
                s[i] = Console.ReadLine();
            }
            
            //String Input to Split
            Console.Write("Enter Input String to Split: ");
            string input = Console.ReadLine();
            
            //String Input to Reverse
            Console.Write("Enter Input String to Reverse: ");
            string rev = Console.ReadLine();
            
            //Inputs for PadLeft
            Console.Write("Enter Input String to Pad: ");
            string pad = Console.ReadLine();
            Console.Write("Enter Number of Characters in a String: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the character to PadLeft: ");
            char a = Convert.ToChar(Console.ReadLine());

            //Function Calling
            Console.WriteLine("**************OUTPUT**************");
            Console.WriteLine("OUTPUT STRING: "+p.JoinIt(s));
            string[] st = p.SplitIt(input);
            Console.WriteLine("AFTER SPLITTING: ");
            foreach (var v in st)
            {
                Console.WriteLine("                "+v);
            }
            Console.WriteLine("AFTER REVERSING: "+p.Reverse(rev));
            Console.WriteLine("AFTER LEFT PADDING: "+p.PadLeft(pad, n, a));
            Console.ReadKey();


        }
    }
}
