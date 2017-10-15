using KataCoffeMachineConsole;
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

        [Test]
        public void Should_Return_The_TeaRefactor_From_The_Factory()
        {
            Idrink drink = Machine.PrepareDrink("Tea");
            Check.That(drink.IsExtraHot()).IsTrue();
        }

        [TestCase("T")]
        public void Should_Return_The_Code_Value_Machine_For_The_Tea(string machineCode)
        {
            var drink = Machine.PrepareDrink("Tea");
            Check.That(drink.DisplayCodeMachine()).IsEqualTo(machineCode);
        }

        [TestCase("T::")]
        public void Should_Return_The_Code_Value_Machine_For_The_Tea_By_The_Command(string machineCode)
        {
            var commandMadeByTheClient = new UserChoice("Tea");
            Check.That(commandMadeByTheClient.DisplayClientCommand()).IsEqualTo(machineCode);
        }

    }
}
