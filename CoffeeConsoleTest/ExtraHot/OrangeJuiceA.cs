using System;

namespace CoffeeConsoleTest.ExtraHot.AcceptanceTest
{
    public class OrangeJuice
    {
        private double price = 0.60;
        private string format = "O";

        public OrangeJuice()
        {
        }

        internal float CalculateThePrice(double price)
        {
            double calculeThePriceRest = this.price - price;
            if (calculeThePriceRest < 0)
            {
                return 0;
            }
            return Convert.ToSingle(calculeThePriceRest);
        }

        public override string ToString()
        {
            return this.format;
        }
    }
}