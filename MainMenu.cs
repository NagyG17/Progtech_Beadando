using System;
using System.Collections.Generic;
using System.Text;

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
                    OMenu.SetOptions();
                    //Options.Clear();
                    
                    break;
                case '2':
                    PMenu.SetOptions();
                    
                    break;
                case '3':
                    SACMenu.SetOptions();
                    
                    break;
                case '4':
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("!!!Megfelelő számot adj meg pls gecszexkriszrossz!!!");
                    break;
            }
            
            SetOptions();
            
            managemenu();

        }
        public List<string> Options = new List<string>();
        public override void SetOptions()
        {
            Options.Clear();
            Console.Clear();
            Options.Add("[1] Order Management");
            Options.Add("[2] Product Management");
            Options.Add("[3] Supplier And Customer Management");
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
