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

        public UserChoice(Sugar sugar,Stick stick)
        {
            this.sugar = sugar;
            this.stick = stick;
        }

        public UserChoice(Coffee coffee, Sugar sugar, Stick stick) : this(sugar,stick)
        {
            this.coffee = coffee;
         
        }

        public UserChoice(Chocolate chocolate, Sugar sugar, Stick stick) : this(sugar, stick)
        {
            this.chocolate = chocolate;
          
        }

        internal string DisplayForCoffee()
        {
            return $"{coffee}{sugar}{stick}";
        }

        internal string DisplayForChocolate()
        {
            return $"{chocolate}{sugar}{stick}"; ;
        }
    }
}