namespace Head_First_Design_Patterns
{
    public class ChocolateBoiler
    {
        private bool _empty;
        private bool _boiled;

        private static ChocolateBoiler _uniqueInstance;

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new ChocolateBoiler();
            }

            return _uniqueInstance;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                _empty = false;
                _boiled = false;
                // fill the thing!
            }
        }

        private bool IsEmpty()
        {
            if (_empty)
            {
                return true;
            }

            return false;
        }
    }
}
