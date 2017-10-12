namespace CoffeeConsoleTest
{
    internal class Stick
    {
        private int numberStick;

        public Stick()
        {
            
        }

        public void ObtainOne()
        {
            numberStick = 1;
        }

        internal string Display()
        {
            return $":{numberStick.ToString()}";
        }

        public override string ToString()
        {
            return $":{numberStick.ToString()}";
        }
    }
}
