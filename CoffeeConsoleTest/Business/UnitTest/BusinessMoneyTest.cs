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
    public class BusinessMoneyTest
    {
        [Test]
        public void AddMoney_Should_Return_40_cents_For_The_Chocolate()
        {
            Chocolate chocolate = new Chocolate();
            Sugar sugar = new Sugar();
            Stick stick = new Stick();
            var userChoice = new UserChoice(chocolate, sugar, stick);
            Check.That(userChoice.AddMoneyForChocolate(0.10)).IsEqualTo(0.40);
        }

        [TestCase(0.40)]
        public void AddMoney_Should_Return_40_Cents_For_The_Chocolate(double number)
        {
            Coffee coffee = new Coffee();
            Sugar sugar = new Sugar();
            Stick stick = new Stick();
            var userChoice = new UserChoice(coffee, sugar, stick);
            float numberConverted = Convert.ToSingle(number);
            Check.That(userChoice.AddMoneyForCoffee(0.20)).IsEqualTo(numberConverted);
        }

        [TestCase(0.30)]
        public void AddMoney_Should_Return_30_Cents_For_The_Chocolate(double number)
        {
            Coffee coffee = new Coffee();
            Sugar sugar = new Sugar();
            Stick stick = new Stick();
            var userChoice = new UserChoice(coffee, sugar, stick);
            float numberConverted = Convert.ToSingle(number);
            Check.That(userChoice.AddMoneyForCoffee(0.30)).IsEqualTo(numberConverted);
        }
    }
}
