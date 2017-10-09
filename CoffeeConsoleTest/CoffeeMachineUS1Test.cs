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
        private const string CoffeeChoice = "Coffee";
        private const string ChcolateChoice = "Chocolate";
        private const string TeaChoice = "Tea";

        [TestCase(CoffeeChoice)]
        [TestCase(ChcolateChoice)]
        [TestCase(TeaChoice)]
        public void Choice_Should_Choice_Only_Between_Chocolate_Coffee_Tea(string choice)
        {
            DrinkChoice drink = new DrinkChoice();
            drink.Choice(choice);
            Check.That(drink.DrinkChoiceUser).IsEqualTo(choice);
        }


        [Test]
        public void Choice_Coffee()
        {
            Coffee coffeeChoice = new Coffee();
            Check.That(coffeeChoice).IsEqualTo(new Coffee());
            
        }

        [Test]
        public void Choice_Chocolate()
        {
            Chocolate chocolateChoice = new Chocolate();
            Check.That(chocolateChoice).IsEqualTo(new Chocolate());
        }


        [Test]
        public void Choice_Tea()
        {
            Tea teaChoice = new Tea();
            Check.That(teaChoice).IsEqualTo(new Tea());
        }

        [Test]
        public void Choice_You_Can_choose_minimum_0_Sugar_Or_2_sugars()
        {
            Chocolate chocolate = new Chocolate();
            DrinkChoice drink = new DrinkChoice();
            Check.ThatCode(() => drink.AddSugar(3)).Throws<Exception>();
        }

        [Test]
        public void Choice_Need_To_Add_One_Suggar()
        {
            Chocolate chocolate = new Chocolate();
            DrinkChoice drink = new DrinkChoice();
            drink.AddSugar(1);
            Check.That(drink.sugar).Equals(1);
        }
    }

    public class DrinkChoice
    {
        public string DrinkChoiceUser { get; private set; }
        private List<string> choiceAvailable = new List<string>();
        public int sugar { get; set; } = 0;
        public bool stick { get; private set; } = false;

        public DrinkChoice()
        {   

            choiceAvailable.Add("Chocolate");
            choiceAvailable.Add("Coffee");
            choiceAvailable.Add("Tea");
        }

        public void Choice(string choice)
        {
            if (choiceAvailable.Contains(choice) == false)
            {
                throw new Exception("The choice need to be between Chocolate, Coffee, Tea");
            }
            DrinkChoiceUser = choice;
        }

        public void AddSugar(int numberSugar)
        {
            if (numberSugar < 0 || numberSugar>2)
            {
                throw new Exception("The number of sugar need to be in minimum 0 and maximum 2");
            }
            sugar = numberSugar;
            stick = true;
        }
    }
}
