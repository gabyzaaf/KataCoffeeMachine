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
        public void Should_Return_Price_When_The_Chocolate_Total_montant_Is_Payed(double number)
        {
            Chocolate chocolate = new Chocolate();
            Sugar sugar = new Sugar();
            Stick stick = new Stick();
            var userChoice = new UserChoice(chocolate, sugar, stick);
            Check.That(userChoice.AddMoneyForChocolate(0.10)).IsEqualTo(number);
        }

        [TestCase(0.40)]
        public void Should_Return_Price_When_The_Coffee_Total_Montant_Is_Payed(double number)
        {
            Coffee coffee = new Coffee();
            Sugar sugar = new Sugar();
            Stick stick = new Stick();
            var userChoice = new UserChoice(coffee, sugar, stick);
            Check.That(userChoice.AddMoneyForCoffee(0.20)).IsEqualTo(Convert.ToSingle(number));
        }

        [TestCase(0)]
        public void Should_Return_Price_When_The_Tea_Total_Montant_Is_Payed(double number)
        {
            Tea tea = new Tea();
            Sugar sugar = new Sugar();
            Stick stick = new Stick();
            var userChoice = new UserChoice(tea, sugar, stick);
            Check.That(userChoice.AddMoneyForTea(0.40)).IsEqualTo(number);
        }
    }

   
}
