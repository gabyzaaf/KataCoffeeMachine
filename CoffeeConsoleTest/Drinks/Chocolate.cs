using System;

namespace CoffeeConsoleTest
{
    public class Chocolate
    {
        public string MachineEncoding { get; private set; } = "H";
        private double price = 0.50;

        public Chocolate()
        {

        }


        public override string ToString()
        {
            return MachineEncoding;
        }

        internal double CalculeThePrice(double price)
        {
            double restPrice = this.price - price;
            if (restPrice < 0)
            {
                return 0;
            }
            return restPrice;
        }
    }
}
