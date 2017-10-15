using System;
using CoffeeConsoleTest;
using CoffeeConsoleTest.ExtraHot.AcceptanceTest;
using CoffeeConsoleTest.MakingMoney;

namespace KataCoffeMachineConsole
{
    public class UserChoice
    {
        private Coffee coffee;
        private Sugar sugar;
        private Stick stick;
        private Chocolate chocolate;
        private Tea tea;
        private OrangeJuice orangeJuice;
        private Idrink drink;

        public UserChoice(Sugar sugar,Stick stick)
        {
            this.sugar = sugar;
            this.stick = stick;
             VerifySugarNumber();
            ObtainOne();
        }

        public UserChoice(Tea tea, Sugar sugar, Stick stick) : this(sugar,stick)
        {
            this.tea = tea;
        }
        
        internal float AddMoneyForOrangeJuice(double price)
        {
            
            return orangeJuice.CalculateThePrice(price);
        }

        public UserChoice(Coffee coffee, Sugar sugar, Stick stick) : this(sugar,stick)
        {
            this.coffee = coffee;
         
        }

        internal string DisplayForOrangeJuice()
        {
            return $"{orangeJuice}{sugar}{stick}";
        }

        internal double AddMoneyForChocolate(double price)
        {

            return chocolate.CalculeThePrice(price);
            
        }

        internal string DisplayClientCommand()
        {
            return $"{drink.DisplayCodeMachine()}{sugar}{stick}";
        }

        public UserChoice(Chocolate chocolate, Sugar sugar, Stick stick) : this(sugar, stick)
        {
            this.chocolate = chocolate;
          
        }

        public UserChoice(OrangeJuice orangeJuice) : this(new Sugar(),new Stick())
        {
            this.orangeJuice = orangeJuice;
        }

        public UserChoice(Coffee coffee):this(new Sugar(),new Stick())
        {
            this.coffee = coffee;
        }

        public UserChoice(Chocolate chocolate): this(new Sugar(),new Stick())
        {
            this.chocolate = chocolate;
        }

        public UserChoice(string drink):this(new Sugar(),new Stick())
        {
            this.drink = Machine.PrepareDrink(drink);

        }

        internal float AddMoneyForCoffee(double price)
        {
            
            return coffee.CalculeThePrice(price);
        }

       

        private void VerifySugarNumber()
        {
            if (!sugar.IsValid())
            {
                throw new Exception("The number is more than 2");
            }
        }

        private void ObtainOne()
        {
            if (this.sugar.IsTake())
            {
                this.stick.ObtainOne();
            }
        }

        internal float AddMoneyForTea(double price)
        {
            return tea.CalculeThePrice(price);
        }

        internal string DisplayForCoffee()
        {
            if (coffee.IsExtraHot())
            {
                return $"{coffee}h{sugar}{stick}";
            }
            return $"{coffee}{sugar}{stick}";
        }

        


        internal string DisplayForChocolate()
        {
            if (chocolate.IsExtraHot())
            {
                return $"{chocolate}h{sugar}{stick}";
            }
            return $"{chocolate}{sugar}{stick}";
        }

        internal object DisplayForTea()
        {
            if (tea.IsExtraHot())
            {
                return $"{tea}h{sugar}{stick}";
            }

            return $"{tea}{sugar}{stick}";
        }
    }
}