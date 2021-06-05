using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment
{
    class Item
    {
        public Item(int Quantity, string ProdName,bool Quality)
        {
            this.quantity = Quantity;
            this.prodName = ProdName;
            this.quality = Quality;
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
        private bool quality;
        public bool Quality
        {
            set { quality = value; }
            get { return quality; }
        }

    }
}
