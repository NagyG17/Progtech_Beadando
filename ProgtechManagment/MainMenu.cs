using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProgtechManagment
{
    
    class MainMenu : MenuBase
    {
        
        protected override void SetPrompt()
        {
            Prompt = "Üdvözöllek a You-CAN-Do-Anything Corp. oldalán. \nVálassz az alábbi menüpontokból!";
        }
        public override void managemenu()
        {
            char c = Console.ReadKey().KeyChar;
            OrderMenu OMenu = new OrderMenu();
            ProductMenu PMenu = new ProductMenu();
            SupplierAndCustomerMenu SACMenu = new SupplierAndCustomerMenu();
            switch (c)
            {
                case '1':
                    OMenu.managemenu();
                    //Options.Clear();
                    
                    break;
                case '2':
                    SACMenu.managemenu();
                    
                    break;
                case '3':
                    PMenu.managemenu();
                    
                    break;
                case '4':
                    Console.WriteLine("A program 5 másodperc múlva bezárodik!");
                    Thread.Sleep(5000);
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Rossz karaktert adtál meg!!! Kérlek a menűszámoknak megfelelő számot adj meg!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    SetOptions();
                    managemenu();
                    break;
            }
            
            SetOptions();
            managemenu();

        }

        new List<string> Options = new List<string>();
        public override void SetOptions()
        {
            Options.Clear();
            Console.Clear();
            Options.Add("[1] Order Management");
            Options.Add("[2] Supplier And Customer Management");
            Options.Add("[3] Product Management");
            Options.Add("[4] Exit");
            SetPrompt();
            Console.WriteLine(Prompt);
            
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine(Options[i]);
                
            }
            
        }

        
    }
}
