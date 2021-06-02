using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment
{
    class SupplierAndCustomerMenu:MenuBase
    {
        
        public override void managemenu() {
            char c = Console.ReadKey().KeyChar;
            switch (c)
            {
                case '1':
                    outPutAllItems();
                    Console.ReadKey();
                    break;
                case '2':
                    //Todo: megcsinálni a warehouseba rakást--> item-hez rakni egy quality mezőt (ami 1 és 2 lehet),
                    //elég egy warehouse,amiben két lista van quality és nem quality pl. lista.addlowqualityItem(item)
                    break;
                case '3':
                    break;
                case '4':
                    Console.Clear();
                    break;
                default:
                    break;
            }
        }
        public void outPutAllItems()
        {
            Items.Lista();
            foreach (var item in Items.Prods)
            {
                Console.WriteLine(item.ProdName + item.Quantity);

            }
        }
        List<string> Options = new List<string>();
        public override void SetOptions()
        {
            Console.Clear();
            Options.Add("[1] A rendelési lista jóváhagyása");
            Options.Add("[2] Szállítás és raktározás");
            Options.Add("[3] Eladás");
            Options.Add("[4] Exit");
            SetPrompt();
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine(Options[i]);

            }

            managemenu();
            Options.Clear();

        }
        protected override void SetPrompt()
        {
            Prompt = "Supplier And Customer management felülete!";
        }

        
    }
}
