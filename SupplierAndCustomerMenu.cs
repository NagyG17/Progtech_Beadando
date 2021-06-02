using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment
{
    class SupplierAndCustomerMenu:MenuBase
    {
        protected override void SetPrompt()
        {
            Prompt = "Supplier And Customer management felülete!";
        }
        
       
        public override void managemenu() {
            char c = Console.ReadKey().KeyChar;
            switch (c)
            {
                case '1':
                    break;
                case '2':
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
    }
}
