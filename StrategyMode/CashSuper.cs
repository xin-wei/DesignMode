using System;

namespace StrategyMode
{
    public abstract class CashSuper
    {
        public abstract double AcceptCash(double money);
    }

    public class CashNormal : CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }

    public class CashRebate : CashSuper
    {
        private readonly double moneyRebate = 1d;

        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }
        public override double AcceptCash(double money)
        {
            return money*moneyRebate;
        }
    }

    public class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;

        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);

        }
        public override double AcceptCash(double money)
        {
            double result = money;
            if (money >= moneyCondition)
            {
                result = money - Math.Floor(money/moneyCondition)*moneyReturn;
            }

            return result;
        }
    }

    public class CashFactory
    {
        public static CashSuper CreateCashAccept(string type)
        {
            CashSuper cs = null;
            switch (type)
            {
                case "Normal":
                    cs = new CashNormal();
                    break;

                case "300-100":
                    cs = new CashReturn("300", "100");
                    break;

                case "0.8":
                    cs = new CashRebate("0.8");
                    break;
            }

            return cs;
        }
    }

}