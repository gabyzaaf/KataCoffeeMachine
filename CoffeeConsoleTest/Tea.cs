using System.Collections.Generic;

namespace CoffeeConsoleTest
{
    public class Tea
    {
        private readonly string chocolate = "tea";

        public override bool Equals(object obj)
        {
            var tea = obj as Tea;
            return tea != null &&
                   chocolate == tea.chocolate;
        }

        public override int GetHashCode()
        {
            return -1671490175 + EqualityComparer<string>.Default.GetHashCode(chocolate);
        }
    }
}
