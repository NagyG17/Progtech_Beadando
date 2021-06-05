using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProgtechManagment
{
    class SupplierAndCustomerMenu:MenuBase
    {
        
        public override void managemenu() {
            SetOptions();
            WarehouseSingleton.getInstance();
            ItemsSingleton.getInstance();
            char c = Console.ReadKey().KeyChar;
            List<Item> soldList = WarehouseSingleton.SoldList;
            switch (c)
            {
                case '1':
                    outPutAllItems();
                    Console.ReadKey();
                    break;
                case '2':
                    if (ItemsSingleton.Prods.Count != 0)
                    {
                        foreach (var item in ItemsSingleton.Prods)
                        {
                            if (item.Quality == false)
                            {
                                WarehouseSingleton.AddToWarehouse(item);
                                Console.WriteLine("A raktárba bekerült: " + item.ProdName + item.Quantity+" db");
                            }
                            else
                            {
                                WarehouseSingleton.AddToQualityWarehouse(item);
                                Console.WriteLine("A raktárba bekerült: " + item.ProdName + item.Quantity + " db");
                            }//todo: mi került bele a raktárakba

                        }

                        ItemsSingleton.Prods.Clear();
                        Console.WriteLine("A megrendelt árú, a megfelelő raktárakba szállítva! \n Nyomj egy gombot a folytatáshoz!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Nincs megrendelés, amit szállítani lehetne");
                        Thread.Sleep(3000);
                    }
                    managemenu();
                    //Todo: megcsinálni a warehouseba rakást--> item-hez rakni egy quality mezőt (ami 1 és 2 lehet),
                    //elég egy warehouse,amiben két lista van quality és nem quality pl. lista.addlowqualityItem(item)
                    break;
                case '3':
                    
                    
                    if (WarehouseSingleton.WarehouseList.Count!=0 || WarehouseSingleton.WarehouseList.Count!=0)
                    {
                        soldList = WarehouseSingleton.CountProduct();
                        WarehouseSingleton.WarehouseList.Clear();
                        WarehouseSingleton.QualityWarehouseList.Clear();
                        Console.WriteLine("A termékek eladva, a bevételt a Product Management számolja ki! \n A termékeket kiürítették a raktárakból. \n Nyomj egy gombot a folytatáshoz!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Nincs termék a raktárokban amit el lehetne adni!");
                        Thread.Sleep(3000);
                    }
                    managemenu();
                    break;
                case '4':
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Rossz karaktert adtál meg!!! Kérlek a menűszámoknak megfelelő számot adj meg!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    SetOptions();
                    managemenu();
                    break;
            }
        }
        public void outPutAllItems()
        {
            ItemsSingleton.getInstance();
            if (ItemsSingleton.Prods.Count != 0)
            {
                foreach (var item in ItemsSingleton.Prods)
                {
                    Console.WriteLine("\n " + item.ProdName + " " + item.Quantity + " db");

                }
            }
            else
                Console.WriteLine("A rendelési lista üres!");
            Thread.Sleep(5000);

        }
        
        new List <string> Options = new List<string>();
        public override void SetOptions()
        {
            Console.Clear();
            Options.Add("[1] A rendelési lista jóváhagyása");
            Options.Add("[2] Szállítás és raktározás");
            Options.Add("[3] Eladás");
            Options.Add("[4] Vissza");
            SetPrompt();
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine(Options[i]);

            }

            
            Options.Clear();

        }
        protected override void SetPrompt()
        {
            Prompt = "Ez a beszállítók és a vásárlók management felülete! Válasz a lehetőségek közül, számmal!";
        }

        
    }
}
