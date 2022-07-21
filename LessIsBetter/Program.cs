using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessIsBetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberWeight nw = new NumberWeight();
            Console.WriteLine(nw.Order("45 34 24 108 76 58 64 130 80")); // 130 24 34 80 108 45 64 58 76"
            Console.WriteLine(nw.Order("    2022 70 123    3344 13 ")); // "13 123 2022 70 3344"
            Console.ReadLine();
        }
    }
}
