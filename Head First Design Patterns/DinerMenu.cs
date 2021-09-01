using System;

namespace Head_First_Design_Patterns
{
    public class DinerMenu : IMenu
    {
        private static int MAX_ITEMS = 6;
        private int _numberOfItems = 0;
        private MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MAX_ITEMS];
            AddItem("Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT",
                "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day",
                "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hotdog",
                "A hot dog, with sauerkraut, relish, onions, topped with cheese",
                false, 3.05);
            // a couple of oth
        }
        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }

        public void AddItem(string name, string description,
            bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (_numberOfItems >= MAX_ITEMS) {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            } else {
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems = _numberOfItems + 1;
            }
        }
    }
}
