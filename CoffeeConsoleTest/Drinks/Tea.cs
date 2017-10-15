using System;

namespace CoffeeConsoleTest
{
    public class Tea
    {
        public string MachineEncoding { get; private set; } = "T";
        private double price = 0.40;
        private bool extraHot;

        public Tea(bool extraHot)
        {
            this.extraHot = extraHot;
        }

        public Tea()
        {

        }

        public string GetEncoding()
        {
            return MachineEncoding;
        }

        public override string ToString()
        {
            return MachineEncoding;
        }

        internal float CalculeThePrice(double price)
        {
            double restOfThePrice = this.price - price;
            if (restOfThePrice < 0)
            {
                return 0;
            }
            return Convert.ToSingle(restOfThePrice);
        }

        internal bool IsExtraHot()
        {
            return extraHot;
        }
    }
}
