using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment
{
    class Items
    {
        public Items(int Id,string TypeOfProduct,int Quantity)
        {
            this.Id = Id;
            this.TypeOfProduct = TypeOfProduct;
            this.Quantity = Quantity;
        }
        private int id;
        public int Id
        {
            set
            {
                if (value > 0)
                    id = value;
            }
            get
            {
                return id;
            }
        }
        private string typeOfProduct;
        public string TypeOfProduct
        {
            set { typeOfProduct = value; }
            get { return typeOfProduct; }

        }
        private int quantity;
        public int Quantity
        {
            set { if (value > 0)
                    quantity = value;
                    
                }
            get { return quantity; }
        }
        private List<Items> orders;
        public List<Items> Orders
        {
            
            get { return new List<Items>(orders); }
        }

    }
}
