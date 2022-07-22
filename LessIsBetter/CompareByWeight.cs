using System.Collections.Generic;

namespace LessIsBetter
{
    internal class CompareByWeight: Comparer<string>
    {
        public override int Compare(string x, string y)
        {
            NumberWeight num = new NumberWeight();
            if (num.CalcWeight(x) == num.CalcWeight(y))
               return x.CompareTo(y);
            return num.CalcWeight(x).CompareTo(num.CalcWeight(y));
        }
    }
}
