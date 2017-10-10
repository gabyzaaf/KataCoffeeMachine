using NFluent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeConsoleTest
{

    public class CoffeeMachineUS1Test
    {
     
        [TestCase("Tea")]
        public void Choose_Tea_Without_Sugar_And_Stick_And_Will_Return_The_Machine_Format(string teaChoosen)
        {
            if ("Tea".Equals(teaChoosen) == false)
            {
                throw new Exception("The choose is not a Tea");
            }

            Tea tea = new Tea();
            Check.That(tea.MachineEncoding).Equals("T:"); 
        }

        [TestCase("Chocolate")]
        public void Choose_Chocolate_Without_Sugar_And_Stick_And_Will_Return_The_Machine_Format(string chocolatChoosen)
        {
            if ("Chocolate".Equals(chocolatChoosen) == false)
            {
                throw new Exception("The choose is not a chocolate");
            }

            Chocolate chocolate = new Chocolate();
            Check.That(chocolate.MachineEncoding).Equals("H:");
        }

        [TestCase("Coffee")]
        public void Choose_Coffee_Without_Sugar_And_Stick_And_Will_Return_The_Machine_Format(string coffeeChoosen)
        {
            if ("Coffee".Equals(coffeeChoosen) == false)
            {
                throw new Exception("The choose is not a coffee");
            }
            Coffee coffee = new Coffee();
            Check.That(coffee.MachineEncoding).Equals("C:");
        }

        
    }

    internal class Coffee
    {
        public string MachineEncoding { get; private set; } = "C:";


    }

    internal class Chocolate
    {
        public string MachineEncoding { get; private set; } = "H:";

        public Chocolate()
        {

        }
    }

    public class Tea
    {
        public string MachineEncoding { get; private set; } = "T:";

        public string GetEncoding()
        {
            return MachineEncoding;
        }

    }
}
