namespace Head_First_Design_Patterns
{
    public class DinerMenuIterator : IIterator
    {
        private MenuItem[] _items;
        private int _position;

        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }
        public MenuItem Next()
        {
            MenuItem menuItem = _items[_position];
            _position = _position + 1;
            return menuItem;
        }
        public bool HasNext()
        {
            return _position >= _items.Length && _items[_position] != null;
        }
    }
}
