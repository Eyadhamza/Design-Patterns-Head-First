using System;
using System.Collections.Generic;

namespace Head_First_Design_Patterns
{
    public class Menu : MenuComponent
    {
        readonly List<MenuComponent> _menuComponents = new List<MenuComponent>();
        readonly String _name;
        readonly String _description;

    public Menu(String name, String description) {
        _name = name;
        _description = description;
    }
    public override void Add(MenuComponent menuComponent) {
        _menuComponents.Add(menuComponent);
    }
    public override void Remove(MenuComponent menuComponent) {
        _menuComponents.Remove(menuComponent);
    }
    public override MenuComponent GetChild(int i) {
        return _menuComponents[i];
    }
    public override string GetName() {
        return _name;
    }
    public override string GetDescription() {
        return _description;
    }
    public override void Print() {
       Console.Write("\n" + GetName());
       Console.Write(", " + GetDescription());
       Console.WriteLine("---------------------");

       foreach (MenuComponent menuComponent in _menuComponents)
       {
           menuComponent.Print();
       }
    }
    }
}
