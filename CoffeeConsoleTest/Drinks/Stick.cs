namespace CoffeeConsoleTest
{
    public class Stick
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
            if (numberStick == 0)
            {
                return ":";
            }
            return $":{numberStick.ToString()}";
        }

        public override string ToString()
        {
            return Display();
        }
    }
}
