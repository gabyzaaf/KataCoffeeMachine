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
        [TestCase(0.4)]
        public void Should_Return_Price_When_The_Chocolate_Total_montant_Is_Payed(double number)
        {
            Chocolate chocolate = new Chocolate();
            Sugar sugar = new Sugar();
            Stick stick = new Stick();
            var userChoice = new UserChoice(chocolate, sugar, stick);
            Check.That(userChoice.AddMoneyForChocolate(0.10)).IsEqualTo(number);
        }

        [TestCase(0.40)]
        public void Should_Return_Code_Price_When_The_Coffee_Total_Montant_Is_Payed(double number)
        {
            Coffee coffee = new Coffee();
            Sugar sugar = new Sugar();
            Stick stick = new Stick();
            var userChoice = new UserChoice(coffee, sugar, stick);
            float numberCalculated = Convert.ToSingle(userChoice.AddMoneyForCoffee(0.20));
            Check.That(numberCalculated).IsEqualTo(Convert.ToSingle(number));
        }
    }
}
