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
            Check.That(drink.IsExtraHot()).IsFalse();
        }

        [Test]
        public void Should_Return_The_TeaRefactor_From_The_Factory()
        {
            Idrink drink = Machine.PrepareDrink("Tea");
            Check.That(drink.IsExtraHot()).IsFalse();
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
            var commandMadeByTheClient = new UserChoice("Tea",null,null);
            Check.That(commandMadeByTheClient.DisplayClientCommand()).IsEqualTo(machineCode);
        }

        [TestCase("T:1:1")]
        public void Should_Return_The_Code_Value_Machine_For_The_Tea_With_One_Sugar_By_The_Command(string machineCode)
        {
            var commandMadeByTheClient = new UserChoice("Tea",new Sugar(1),new Stick());
            Check.That(commandMadeByTheClient.DisplayClientCommand()).IsEqualTo(machineCode);
        }

        [TestCase("T:2:1")]
        public void Should_Return_The_Code_Value_Machine_For_The_Tea_With_Two_Sugar_By_The_Command(string machineCode)
        {
            var commandMadeByTheClient = new UserChoice("Tea", new Sugar(2), new Stick());
            Check.That(commandMadeByTheClient.DisplayClientCommand()).IsEqualTo(machineCode);
        }


        [TestCase("Th:2:1")]
        public void Should_Return_The_Code_Value_Machine_For_The_HotTea_With_Two_Sugar_By_The_Command(string machineCode)
        {
            var commandMadeByTheClient = new UserChoice("Tea", new Sugar(2), new Stick(),true);
            Check.That(commandMadeByTheClient.DisplayClientCommand()).IsEqualTo(machineCode);
        }

    }
}
