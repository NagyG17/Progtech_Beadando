using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment
{
    class QualityWarehouseSingleton
    {
        private static QualityWarehouseSingleton qwarehouse = null;
        private QualityWarehouseSingleton()
        { }
        public static QualityWarehouseSingleton Lista() //ToDo: rákell jönni, hogy lesz ebből lista,amihez a cuccokat tudjuk adni
        {
            if (qwarehouse == null) // megvizsgálja, hogy létezik-e már egy példány
                qwarehouse = new QualityWarehouseSingleton(); // ha nem, akkor létrehozza azt

            // visszaadja a példányt
            return qwarehouse;
        }
    }
}
