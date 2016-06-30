using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyMode
{
    class Program
    {
        static void Main(string[] args)
        {
            CashContext csuper = new CashContext("0.8");
            double totalPrices = 0d;
            totalPrices = csuper.GetResult(20*20);

            Console.WriteLine(totalPrices);
            Console.ReadKey();
        }
    }
}
