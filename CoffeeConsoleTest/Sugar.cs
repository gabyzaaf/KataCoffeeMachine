namespace CoffeeConsoleTest
{
    internal class Sugar
    {
        private int sugar;

        public Sugar()
        {
        }

        public Sugar(int sugar)
        {
            this.sugar = sugar;
        }

        public bool IsValid()
        {
            if (this.sugar <0 || this.sugar > 2 )
            {
                return false;
            }
            return true;
        }

        public string NumberSugarForTheScreen()
        {
            if (sugar == 0)
            {
                return ":";
            }
            return $":{this.sugar.ToString()}";
        }

        public override string ToString()
        {
            return NumberSugarForTheScreen();
        }
    }
}
