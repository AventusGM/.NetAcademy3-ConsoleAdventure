using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public class Inventory
    {
        public ObservableCollection<Item> Items { get; protected set; }
        public double TotalWeight { get; protected set; }

        public Inventory() 
        {
            Items.CollectionChanged += Items_CollectionChanged;
        }

        public Inventory(List<Item> items) : this()
        {
            Items = Items;
        }

        private void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            TotalWeight = 0;
            foreach(Item item in Items)
            {
                TotalWeight += item.Weight;
            }
        }
    }
}
