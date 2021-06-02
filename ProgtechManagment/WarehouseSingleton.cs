using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment
{
    class WarehouseSingleton
    {
        private static WarehouseSingleton warehouse = null;
        private WarehouseSingleton()
        { }
        public static WarehouseSingleton Lista() //ToDo: rákell jönni, hogy lesz ebből lista,amihez a cuccokat tudjuk adni
        {
            if (warehouse == null) // megvizsgálja, hogy létezik-e már egy példány
                warehouse = new WarehouseSingleton(); // ha nem, akkor létrehozza azt

            // visszaadja a példányt
            return warehouse;
        }
        //xy lista
    }
}
