using KataCoffeMachineConsole;
using NFluent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeConsoleTest.Business
{
    class BusinessMoneyAcceptanceTest
    {
        [TestCase(0.40)]
        public void Should_Return_Code_When_The_Total_montant_Is_Payed(int number)
        {
            Chocolate chocolate = new Chocolate();
            Sugar sugar = new Sugar();
            Stick stick = new Stick();
            var userChoice = new UserChoice(chocolate, sugar, stick);
            Check.That(userChoice.AddMoneyForChocolate(0.10)).IsEqualTo(number);
        }
    }
}
