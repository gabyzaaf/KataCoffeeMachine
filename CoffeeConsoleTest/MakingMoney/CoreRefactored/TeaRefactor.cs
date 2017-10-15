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
        private bool extraHot;

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
            return extraHot;
        }

        public void NeedToBeHot()
        {
            extraHot = true;
        }
    }
}