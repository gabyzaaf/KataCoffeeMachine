using System.Collections.Generic;

namespace CoffeeConsoleTest
{
    public class Coffee
    {
        private readonly string coffee = "coffee";

        public Coffee()
        {

        }

        public override bool Equals(object obj)
        {
            var coffee = obj as Coffee;
            return coffee != null &&
                   this.coffee == coffee.coffee;
        }

        public override int GetHashCode()
        {
            return 105650377 + EqualityComparer<string>.Default.GetHashCode(coffee);
        }

        public override string ToString()
        {
            return coffee;
        }
    }
}
