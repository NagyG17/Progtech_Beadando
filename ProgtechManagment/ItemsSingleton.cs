using System;
using System.Collections.Generic;
using System.Text;
using ProgtechManagment.Decorator;

namespace ProgtechManagment
{
    class ItemsSingleton
    {

        private static ItemsSingleton items = null;
        private ItemsSingleton()
        {
            prods = new List<Item>();        
        }
        public static ItemsSingleton getInstance()
        {
            if (items == null) // megvizsgálja, hogy létezik-e már egy példány
                items = new ItemsSingleton(); // ha nem, akkor létrehozza azt

            // visszaadja a példányt
            return items;
        }
        
        public static void addItem(int quantity,string prodName, bool quality)
        {
            prods.Add(new Item(quantity, prodName, quality));
        }
        
        
        
        private static List<Item> prods;
        public static List<Item> Prods
        {
            
            get { return prods; }
        }

    }
}
