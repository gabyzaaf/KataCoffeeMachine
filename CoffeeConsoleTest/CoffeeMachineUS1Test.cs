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

        [Test]
        public void Need_To_Return_One_Stick()
        {
            Chocolate chocolate = new Chocolate();
            DrinkChoice drink = new DrinkChoice();
            drink.AddSugar(1);
            Check.That(drink.stick).Equals(true);
        }

        [Test]
        public void Choice_Chocolate_To_Drink()
        {
            DrinkChoice drink = new DrinkChoice();
            drink.Choice(new Chocolate());
            Check.That(drink.Chocolate.ToString()).Equals("chocolate");

        }

        [Test]
        public void Choice_Coffee_To_Drink()
        {
            DrinkChoice drink = new DrinkChoice();
            drink.Choice(new Coffee());
            Check.That(drink.Coffee.ToString()).Equals("coffee");
        }

        [Test]
        public void Choice_Tea_To_Drink()
        {
            DrinkChoice drink = new DrinkChoice();
            drink.Choice(new Tea());
            Check.That(drink.Tea.ToString()).Equals("tea");
        }

        
    }

    public class DrinkChoice
    {
        public Tea Tea { get; private set; } = null;
        public Coffee Coffee {get;  private set;} = null;
        public Chocolate Chocolate { get; private set; } = null;

        public int sugar { get; set; } = 0;
        public bool stick { get; private set; } = false;



        public void AddSugar(int numberSugar)
        {
            
            if (numberSugar < 0 || numberSugar>2)
            {
                throw new Exception("The number of sugar need to be in minimum 0 and maximum 2");
            }
            sugar = numberSugar;
            stick = true;
        }

        public void Choice(Chocolate chocolate)
        {
            this.Chocolate = chocolate;
        }

        public void Choice(Coffee coffee)
        {
            this.Coffee = coffee;
        }

        internal void Choice(Tea tea)
        {
            Tea = tea;
        }
    }
}
