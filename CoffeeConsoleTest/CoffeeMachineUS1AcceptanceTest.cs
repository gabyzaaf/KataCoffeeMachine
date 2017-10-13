using CoffeeConsoleTest;
using NFluent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCoffeMachineConsole
{
    class CoffeeMachineUS1AcceptanceTest
    {
        [TestCase("T:1:1")]
        public void Should_Return_Specific_Format_For_1_Tea_1_Sugar_0_Stick(string parametersCode)
        {
            Tea tea = new Tea();
            Sugar sugar = new Sugar(1);
            Stick stick = new Stick();
            stick.ObtainOne();
            Check.That($"{tea}{sugar}{stick}").IsEqualTo(parametersCode);
        }

        [TestCase("C::")]
        public void Should_Return_Specific_Format_For_1_Chocolate_0_Sugar_0_Stick(string parametersCode)
        {
            Coffee coffee = new Coffee();
            Sugar sugar = new Sugar(0);
            Stick stick = new Stick();
            var userChoice = new UserChoice(coffee,sugar,stick);
            Check.That(userChoice.DisplayForCoffee()).IsEqualTo("C::");
        }
    }
}
