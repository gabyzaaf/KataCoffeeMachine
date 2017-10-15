using System;

namespace CoffeeConsoleTest.MakingMoney
{
    public class Machine
    {
        public static Idrink PrepareDrink(string drink)
        {
            if (drink.Equals("Tea"))
            {
                return new TeaRefactor();
            }
            return null;
        }
    }
}