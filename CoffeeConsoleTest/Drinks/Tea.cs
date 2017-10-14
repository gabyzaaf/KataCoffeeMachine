namespace CoffeeConsoleTest
{
    public class Tea
    {
        public string MachineEncoding { get; private set; } = "T";

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
