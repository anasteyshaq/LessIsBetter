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
            Console.WriteLine(nw.Order("3 16 9 38 95 1131268 49455 347464 59544965313 4966378768798798789798769861112"));
            Console.WriteLine(nw.Order("    2022 70 123    3344 13 ")); // "13 123 2022 70 3344"
            Console.WriteLine(nw.Order("    ")); // "13 123 2022 70 3344"
            Console.WriteLine(nw.Order("  3 27 93 11 3209 2 2784 11111 3762  "));
            Console.ReadLine();
        }
    }
}
