using System.Collections.Generic;

namespace LessIsBetter
{
    internal class CompareByWeight: Comparer<int>
    {
        public override int Compare(int x, int y)
        {
            NumberWeight num = new NumberWeight();
            if (num.CalcWeight(x) == num.CalcWeight(y))
               return x.ToString().CompareTo(y.ToString());
            return num.CalcWeight(x).CompareTo(num.CalcWeight(y));
        }
    }
}
