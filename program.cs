using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] stri = str.ToCharArray();
            Array.Reverse(stri);
            string ready = new string(stri);
            Console.WriteLine(ready);
            Console.ReadKey();
        }
    }
