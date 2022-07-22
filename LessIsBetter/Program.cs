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
            Console.WriteLine(nw.Order("3 16 9 38 95 1131268 49455 347464 59544965313 4966369861112"));
            Console.WriteLine(nw.Order("    2022 70 123    3344 13 ")); // "13 123 2022 70 3344"
            Console.ReadLine();
        }
    }
}
