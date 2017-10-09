using System.Collections.Generic;

namespace CoffeeConsoleTest
{
    public class Tea
    {
        private readonly string tea = "tea";

        public override bool Equals(object obj)
        {
            var tea = obj as Tea;
            return tea != null &&
                   this.tea == tea.tea;
        }

        public override int GetHashCode()
        {
            return -1671490175 + EqualityComparer<string>.Default.GetHashCode(tea);
        }

        public override string ToString()
        {
            return tea;
        }
    }
}
