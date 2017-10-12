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
            Check.That(tea.MachineEncoding).Equals("T"); 
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
            Check.That(coffee.MachineEncoding).Equals("C");
        }


        [Test]
        public void AddSugar_Add_minimum_0_and_max_2()
        {
                Sugar sugar = new Sugar(2);
                Check.That(sugar.IsValid()).IsTrue();
        }

        [Test]
        public void DisplaySugar_Should_Display_The_Sugar_Number_If_The_Sugar_Number_is_Valid()
        {
            int sugarNumber = 2;
            Sugar sugar = new Sugar(sugarNumber);
            if (sugar.IsValid())
            {
                Check.That(sugar.NumberSugarForTheScreen()).IsEqualTo(":2");
            }
        }

        [Test]
        public void ChooseStick_Should_return_One_Stick()
        {
            Stick stick = new Stick();
            stick.ObtainOne();
            string stickAvailable = stick.Display();
            Check.That(stickAvailable).IsEqualTo(":1");
        }

        [Test]
        public void Choose_Coffee_Without_Sugar()
        {
            Coffee coffee = new Coffee();
            Sugar sugar = new Sugar(0);
            Stick stick = new Stick();
            string machineFormat = $"{coffee.MachineEncoding}{sugar.NumberSugarForTheScreen()}{stick.Display()}";
            Check.That(machineFormat).IsEqualTo("C:0:0");
        }


        
    }
}
