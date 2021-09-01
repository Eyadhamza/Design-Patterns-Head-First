namespace Head_First_Design_Patterns
{
    public class MenuItem
    {
        private readonly string _name;

        public string Name => _name;

        public string Description => _description;

        public bool Vegetarian => _vegetarian;

        public double Price => _price;

        private readonly string _description;
        private readonly bool _vegetarian;
        private readonly double _price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
        }
    }
}
