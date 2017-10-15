using System;
using CoffeeConsoleTest;

namespace KataCoffeMachineConsole
{
    public class UserChoice
    {
        private Coffee coffee;
        private Sugar sugar;
        private Stick stick;
        private Chocolate chocolate;
        private Tea tea;

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

        public UserChoice(Coffee coffee, Sugar sugar, Stick stick) : this(sugar,stick)
        {
            this.coffee = coffee;
         
        }

        internal double AddMoneyForChocolate(double price)
        {

            return chocolate.CalculeThePrice(price);
            
        }

        public UserChoice(Chocolate chocolate, Sugar sugar, Stick stick) : this(sugar, stick)
        {
            this.chocolate = chocolate;
          
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
            return $"{coffee}{sugar}{stick}";
        }

        internal string DisplayForChocolate()
        {
            return $"{chocolate}{sugar}{stick}";
        }

        internal object DisplayForTea()
        {
            return $"{tea}{sugar}{stick}";
        }
    }
}