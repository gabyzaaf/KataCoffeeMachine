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
            Verify();
        }

        public UserChoice(Tea tea, Sugar sugar, Stick stick) : this(sugar,stick)
        {
            this.tea = tea;
        }

        public UserChoice(Coffee coffee, Sugar sugar, Stick stick) : this(sugar,stick)
        {
            this.coffee = coffee;
         
        }

        public UserChoice(Chocolate chocolate, Sugar sugar, Stick stick) : this(sugar, stick)
        {
            this.chocolate = chocolate;
          
        }

        private void Verify()
        {
            if (this.sugar.IsTake())
            {
                this.stick.ObtainOne();
            }
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