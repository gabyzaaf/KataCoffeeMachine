namespace CoffeeConsoleTest
{
    internal class Coff
    {
        public string MachineEncoding { get; private set; } = "H:";

        public Coff()
        {

        }

        public override string ToString()
        {
            return MachineEncoding;
        }
    }
}
