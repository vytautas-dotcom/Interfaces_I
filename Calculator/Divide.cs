using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Divide : Calculator
    {
        public override void DoCalculation(int x, int y)
        {
            Console.WriteLine((double)x/y);
        }
    }
}
