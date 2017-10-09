using System.Collections.Generic;

namespace CoffeeConsoleTest
{
    public class Chocolate
    {
        private readonly string chocolate = "chocolate";

        public override bool Equals(object obj)
        {
            var chocolate = obj as Chocolate;
            return chocolate != null &&
                   this.chocolate == chocolate.chocolate;
        }

        public override int GetHashCode()
        {
            return -1671490175 + EqualityComparer<string>.Default.GetHashCode(chocolate);
        }

        public override string ToString()
        {
            return chocolate;
        }
    }
}
