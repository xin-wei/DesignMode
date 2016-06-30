namespace StrategyMode
{
    public class CashContext
    {
        private CashSuper cs;

        public CashContext(string type)
        {
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
        }

        public double GetResult(double money)
        {
            return cs.AcceptCash(money);
        }
    }
}