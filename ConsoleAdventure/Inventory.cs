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
            if(Items == null) Items = new ObservableCollection<Item>();
            Items.CollectionChanged += Items_CollectionChanged;
        }

        public Inventory(ObservableCollection<Item> items) : this()
        {
            Items = items;
            CalculateWeight();
        }

        private void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            CalculateWeight();
        }

        private void CalculateWeight()
        {
            TotalWeight = 0;
            foreach (Item item in Items)
            {
                TotalWeight += item.Weight;
            }
        }
    }
}
