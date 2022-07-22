using System.Collections.Generic;

namespace LessIsBetter
{
    internal class CompareByWeight: Comparer<ulong>
    {
        public override int Compare(ulong x, ulong y)
        {
            NumberWeight num = new NumberWeight();
            if (num.CalcWeight(x) == num.CalcWeight(y))
               return x.ToString().CompareTo(y.ToString());
            return num.CalcWeight(x).CompareTo(num.CalcWeight(y));
        }
    }
}
