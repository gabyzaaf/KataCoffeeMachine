using System;
using CoffeeConsoleTest;

namespace KataCoffeMachineConsole
{
    internal class UserChoice
    {
        private Coffee coffee;
        private Sugar sugar;
        private Stick stick;

        public UserChoice(Coffee coffee, Sugar sugar, Stick stick)
        {
            this.coffee = coffee;
            this.sugar = sugar;
            this.stick = stick;
        }

       

        internal string DisplayForCoffee()
        {
            return $"{coffee}{sugar}{stick}";
        }




    }
}