using System.Collections.Generic;

namespace Head_First_Design_Patterns
{
    public class PancakeHouseMenuIterator : IIterator
    {
        List<MenuItem> _menuItems;

        public PancakeHouseMenuIterator(List<MenuItem> menuItems)
        {
            _menuItems = menuItems;
        }

        public MenuItem Next()
        {
            throw new System.NotImplementedException();
        }

        public bool HasNext()
        {
            throw new System.NotImplementedException();
        }


    }
}
