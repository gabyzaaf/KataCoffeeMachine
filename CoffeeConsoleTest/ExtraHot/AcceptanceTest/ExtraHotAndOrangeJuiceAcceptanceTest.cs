using KataCoffeMachineConsole;
using NFluent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeConsoleTest.ExtraHot.AcceptanceTest
{
    class ExtraHotAndOrangeJuiceAcceptanceTest
    {
        [TestCase(0.40)]
        public void Should_Return_An_Orange_juice_With_Price_60_cents(double price)
        {
            var orangeJuice = new OrangeJuice();   
            var userChoice = new UserChoice(orangeJuice);

            Check.That(userChoice.AddMoneyForOrangeJuice(0.20)).IsEqualTo(Convert.ToSingle(price));
        }

        [TestCase("O::")]
        public void Should_Return_The_Good_Format(string orangeJuiceFormat)
        {
            var orangeJuice = new OrangeJuice();
            var userChoice = new UserChoice(orangeJuice);
            Check.That(userChoice.DisplayForOrangeJuice()).IsEqualTo(orangeJuiceFormat);
        }

        [TestCase("Ch::")]
        public void Should_Add_ExtraHot_Coffee_Without_Sugar(string extraHotCoffeeFormat)
        {
            Coffee coffee = new Coffee(true);
            var userChoice = new UserChoice(coffee);
            Check.That(userChoice.DisplayForCoffee()).IsEqualTo(extraHotCoffeeFormat);
        }

        [TestCase("Hh:1:1")]
        public void Should_Add_ExtraHot_Chocolate_With_One_Sugar_And_One_Stick(string extratHotChocolateFormat)
        {
            var chocolate = new Chocolate(true);
            var sugar = new Sugar(1);
            var stick = new Stick();
            var userChoice = new UserChoice(chocolate,sugar,stick);
            string userChoiceFormat =  userChoice.DisplayForChocolate();
            Check.That(userChoiceFormat).IsEqualTo(extratHotChocolateFormat);
        }

        [TestCase("Th:2:1")]
        public void Should_Add_ExtraHot_Tea_With_Two_Sugar_And_One_Stick(string extraHotTea)
        {
            var tea = new Tea(true);
            var sugar = new Sugar(2);
            var stick = new Stick();
            var userChoice = new UserChoice(tea, sugar, stick);
            Check.That(userChoice.DisplayForTea()).IsEqualTo(extraHotTea);
        }

    }
}
