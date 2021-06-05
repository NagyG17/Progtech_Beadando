using System;
using System.Collections.Generic;
using System.Text;
using ProgtechManagment.Decorator;

namespace ProgtechManagment
{
    class WarehouseSingleton
    {
        private static WarehouseSingleton warehouse = null;
        private WarehouseSingleton()
        {
            warehouseList =new List<Item>();
            qualityWarehouseList = new List<Item>();
            soldList = new List<Item>();
        }
        public static WarehouseSingleton getInstance() //ToDo: rákell jönni, hogy lesz ebből lista,amihez a cuccokat tudjuk adni
        {
            if (warehouse == null) // megvizsgálja, hogy létezik-e már egy példány
                warehouse = new WarehouseSingleton(); // ha nem, akkor létrehozza azt

            // visszaadja a példányt
            return warehouse;
        }
        private static List<Item> warehouseList;
        public static List<Item> WarehouseList
        {
            get { return warehouseList; }
        }
        private static List<Item> qualityWarehouseList;
        public static List<Item> QualityWarehouseList
        {
            get { return qualityWarehouseList; }
        }
        private static List<Item> soldList;
        public static List<Item> SoldList
        {
            get { return soldList; }
        }


        public static void AddToWarehouse(Item prod)
        {
            warehouseList.Add(prod);
        }
        public static void AddToQualityWarehouse(Item prod)
        {
            qualityWarehouseList.Add(prod);
        }
        public static List<Item> CountProduct()
        {            
            TomatoCan TC = new TomatoCan();
            BeanCan BC = new BeanCan();
            int n=0;
            int k = 0;
            
            
            foreach (var item in warehouseList)
            {
                if (item.ProdName == TC.status())
                {
                        n = item.Quantity + n;
                }
                else
                {
                        k = item.Quantity + k;
                }
            }
            
            soldList.Add(new Item(n, TC.status(), false));
            soldList.Add(new Item(k, BC.status(), false));
            n = 0;
            k = 0;
            QualityTomatoCan QTC = new QualityTomatoCan(TC);
            QualityBeanCan QBC = new QualityBeanCan(BC);
            foreach (var item in qualityWarehouseList)
            {
                if (item.ProdName == QTC.status())
                {
                    n = item.Quantity + n;
                }
                else
                {
                    k = item.Quantity + k;
                }
            }
            soldList.Add(new Item(n, QTC.status(), true));
            soldList.Add(new Item(k, QBC.status(), true));
            
            return soldList;
        }
    }
}
