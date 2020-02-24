using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ShoppingList
{
    public class ShoppingListData: INotifyPropertyChanged
    {
        List<string> items = new List<string>();

        public IEnumerable<string> Items => items.ToArray();   //must be careful here if want to preserve true data hiding

        public event PropertyChangedEventHandler PropertyChanged; //must read like this

        //if using a reference type here, public property can have direct control of private backing variable

        public void Add(string item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items")); //Critically important this is spelled EXACTLY the same
            //would be null if there is no "listener" or binding on object
        }

        public void Remove(string item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
