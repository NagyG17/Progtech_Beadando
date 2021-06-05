using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProgtechManagment
{
    class ProductMenu:MenuBase
    {
        const double qPrice = 200;
        const double price = 100;
        List<Item> soldList = new List<Item>();
        
        public override void managemenu() {
            SetOptions();
            WarehouseSingleton.getInstance();
            ItemsSingleton.getInstance();
            List<Item> soldList = WarehouseSingleton.SoldList;
            
            char c = Console.ReadKey().KeyChar;
            switch (c)
            {
                case '1':
                    double sumProfit=0;
                    if (soldList.Count != 0)
                    {
                        foreach (var item in soldList)
                        {
                            if (item.Quality == false)
                            {
                                sumProfit = sumProfit + item.Quantity * price;
                            }
                            else
                            {
                                sumProfit = sumProfit + item.Quantity * qPrice;
                            }
                        }
                        Console.WriteLine("Az eladott termékekből befolyt összeg: " + sumProfit + " Ft! Nyomj egy gombot a folytatáshoz!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Nem került eladásra egy termék sem!");
                        Thread.Sleep(3000);
                    }
                    managemenu();
                    break;
                case '2':
                    if (soldList.Count != 0)
                    {
                        foreach (var item in soldList)
                        {
                            Console.WriteLine(item.ProdName + " - " + " " + item.Quantity + " db");
                        }

                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Nem került eladásra egy termék sem!");
                        Thread.Sleep(3000);
                    }
                    managemenu();
                    break;
                case '3': 
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

        List<string> Options = new List<string>();
        public override void SetOptions()
        {
            Console.Clear();
            Options.Add("[1] Az eladott termékekből származó bevétel");
            Options.Add("[2] Eladott termékek listája");
            Options.Add("[3] Vissza");
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
            Prompt = "Product management felület";
        }
    }
}
