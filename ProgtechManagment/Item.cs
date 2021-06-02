using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment
{
    class Item
    {
        public Item(int Quantity, string ProdName)
        {
            this.quantity = Quantity;
            this.prodName = ProdName;
        }
        private int quantity;
        public int Quantity
        {
            set { if (value > 0)
                    quantity = value;
                }
            get { return quantity; }
        }
        private string prodName;
        public string ProdName
        {
            set
            {
                prodName = value;
            }
            get { return prodName; }
        }
    }
}
