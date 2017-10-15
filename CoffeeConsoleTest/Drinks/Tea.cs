namespace CoffeeConsoleTest
{
    public class Tea
    {
        public string MachineEncoding { get; private set; } = "T";
        private double price = 0.40;

        public string GetEncoding()
        {
            return MachineEncoding;
        }

        public override string ToString()
        {
            return MachineEncoding;
        }
    }
}
