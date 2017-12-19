using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad;
            Console.Write("ADINIZI GİRİNİZ:");
            ad = Console.ReadLine();
            foreach(char a in ad)
                Console.Write((char)(a+10));
            Console.ReadKey();
        }
    }
}
