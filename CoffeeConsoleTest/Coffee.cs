namespace CoffeeConsoleTest
{
    public class Coffee
    {
        public string MachineEncoding { get; private set; } = "C";

        public override string ToString()
        {
            return MachineEncoding;
        }
    }
}
