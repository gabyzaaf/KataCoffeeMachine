using NFluent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeConsoleTest.MakingMoney
{
    class MakingMoneyUnitTest
    {
        [Test]
        public void Should_Return_The_Code_Format_After_refacto()
        {
            Idrink drink = new TeaRefactor();
            Check.That(drink.IsExtraHot()).IsTrue();
        }


    }
}
