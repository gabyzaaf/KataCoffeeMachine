﻿using KataCoffeMachineConsole;
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

    }
}
