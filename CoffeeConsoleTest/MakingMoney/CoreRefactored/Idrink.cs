using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeConsoleTest.MakingMoney
{
    public interface Idrink
    {
        float CalculeThePrice(double price);
        bool IsExtraHot();
        string DisplayCodeMachine();
        void NeedToBeHot();
    }
}
