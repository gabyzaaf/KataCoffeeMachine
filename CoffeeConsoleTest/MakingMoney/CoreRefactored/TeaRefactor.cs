using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CoffeeConsoleTest.MakingMoney
{
    public class TeaRefactor : Idrink
    {

        private readonly string machineCode = "T";

        public float CalculeThePrice(double price)
        {
            throw new NotImplementedException();
        }

        public string DisplayCodeMachine()
        {
            return machineCode;
        }

        public bool IsExtraHot()
        {
            return true;
        }



        
    }
}