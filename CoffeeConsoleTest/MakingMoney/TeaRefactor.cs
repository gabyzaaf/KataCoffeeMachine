using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CoffeeConsoleTest.MakingMoney
{
    public class TeaRefactor : Idrink
    {
        public float CalculeThePrice(double price)
        {
            throw new NotImplementedException();
        }

        public bool IsExtraHot()
        {
            return true;
        }
    }
}