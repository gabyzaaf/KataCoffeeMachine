using System;

namespace CoffeeConsoleTest
{
    public class Coffee
    {
        public string MachineEncoding { get; private set; } = "C";
        private double price = 0.60;
        private bool extrahot;

        public Coffee()
        {

        }

        public Coffee(bool extraHot)
        {
            this.extrahot = extraHot;
        }

        public override string ToString()
        {
            return MachineEncoding;
        }

        internal float CalculeThePrice(double price)
        {
            
            float restPrice = Convert.ToSingle(this.price - price);
            if (restPrice < 0)
            {
                return 0;
            }
            return restPrice;
        }


        public bool IsExtraHot()
        {
            return extrahot;
        }
    }
}
