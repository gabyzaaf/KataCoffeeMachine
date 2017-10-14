namespace CoffeeConsoleTest
{
    public class Chocolate
    {
        public string MachineEncoding { get; private set; } = "H";

        public Chocolate()
        {

        }


        public override string ToString()
        {
            return MachineEncoding;
        }
    }
}
