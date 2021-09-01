using System;
using System.Collections.Generic;

namespace Head_First_Design_Patterns
{
    public class Waitress
    {
        private IMenu _pancakeHouseMenu;
        private IMenu _dinerMenu;
        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu) {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }
        public void PrintMenu() {
            IIterator pancakeIterator = _pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = _dinerMenu.CreateIterator();
           Console.WriteLine("MENU\n----\nBREAKFAST");
            printMenu(pancakeIterator);
           Console.WriteLine("\nLUNCH");
            printMenu(dinerIterator);
        }
        private void printMenu(IIterator iterator) {
            while (iterator.HasNext()) {
                MenuItem menuItem = iterator.Next();
                Console.WriteLine(menuItem.Name + ", ");
                Console.WriteLine(menuItem.Price + " -- ");
               Console.WriteLine(menuItem.Description);
            }
        }
        // other methods here
    }
}
