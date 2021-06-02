using System;
using System.Collections.Generic;
using System.Text;
using ProgtechManagment.Decorator;

namespace ProgtechManagment
{
    class Items
    {

        private static Items items = null;
        private Items()
        {
            prods = new List<Item>();        
        }
        public static Items Lista() //ToDo: rákell jönni, hogy lesz ebből lista,amihez a cuccokat tudjuk adni
        {
            if (items == null) // megvizsgálja, hogy létezik-e már egy példány
                items = new Items(); // ha nem, akkor létrehozza azt

            // visszaadja a példányt
            return items;
        }
        /*public Items() //Singelton-nak kell lennie
        {
            
            
        }*/
        public static void addItem(int quantity,string prodName)
        {
            prods.Add(new Item(quantity, prodName));
        }
        
        
        
        private static List<Item> prods;
        public static List<Item> Prods
        {
            
            get { return prods; }
        }

    }
}
