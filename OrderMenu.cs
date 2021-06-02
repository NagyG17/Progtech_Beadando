using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment
{
    class OrderMenu : MenuBase
    {
        protected override void SetPrompt()
        {
            Prompt = "Ez az Order Management oldala. \nVálassz az alábbi lehetőségekből, add meg melyik terméket szeretnéd megrendelni!";
        }
        
        private int consoleWriteClear(string productName)
         {
             Console.Clear();
             Console.WriteLine("Add meg mennyi " + productName + " konzervet szeretnél rendelni!");
             return Convert.ToInt32(Console.ReadLine());


         }
         
         public Dictionary<string, int> lista = new Dictionary<string, int>();

         public override void managemenu() {

            char c = Console.ReadKey().KeyChar;
            switch (c)
                {
                    case '1':
                        int n = consoleWriteClear("paradicsomos");
                        lista.Add("Paradicsomos", n);
                        
                        
                        managemenu();

                        break;

                    case '5':
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
            

            Options.Add("[1] Paradicsomos konzerv");
            Options.Add("[2] Bab konzerv");
            Options.Add("[3] Minőségi paradicsomos konzerv");
            Options.Add("[4] Minőségi bab konzerv");
            Options.Add("[5] Exit");
            SetPrompt();
            Console.WriteLine(Prompt);
            
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine(Options[i]);
                
            }

            managemenu();
            Options.Clear();

        }
        
        /*public override void drawMenu()
        {
            Console.Clear();
            SetPrompt();
            Console.WriteLine(Prompt);
            SetOptions();
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine(Options[i]);
            }
        }*/
    }
}
