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
        public void Choose_Tea_Without_Sugar_And_Stick(string teaChoosen)
        {
            if ("Tea".Equals(teaChoosen) == false)
            {
                throw new Exception("The choose is not a tea");
            }

            Tea tea = new Tea();
            Check.That(tea.MachineEncoding).Equals("T");
            
        }
    }

    public class Tea
    {
        public string MachineEncoding { get; private set; } = "T";

        public string GetEncoding()
        {
            return MachineEncoding;
        }

    }
}
