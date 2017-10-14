using KataCoffeMachineConsole;
using NFluent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeConsoleTest.Business.UnitTest
{
    public class BusinessMoney
    {
        [Test]
        public void AddMoney_Should_Return_40_cents()
        {
            Chocolate chocolate = new Chocolate();
            Sugar sugar = new Sugar();
            Stick stick = new Stick();
            var userChoice = new UserChoice(chocolate, sugar, stick);
            Check.That(userChoice.AddMoneyForChocolate(0.10)).IsEqualTo(0.40);
        }
    }
}
