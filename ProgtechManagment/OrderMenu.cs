using System;
using System.Collections.Generic;
using System.Text;
using ProgtechManagment.Decorator;
using System.Threading;

namespace ProgtechManagment
{
    class OrderMenu : MenuBase
    {
         
        public override void managemenu() {
            SetOptions();
            int n;
            TomatoCan TC = new TomatoCan();
            BeanCan BC = new BeanCan();
            char c = Console.ReadKey().KeyChar;
            ItemsSingleton.getInstance();
            
            switch (c)
                {
                    
                    case '1':
                        
                        n= inputQuantity(TC.status());
                    if (n != 0)
                        ItemsSingleton.addItem(n, TC.status(), false);
                    else
                        Console.WriteLine("A " + n + " db termék nem értelmezhető! Kérlek adj meg egy helyes mennyiséget!");
                    Thread.Sleep(1000);
                    managemenu();
                    break;
                    case '2':
                        
                        n = inputQuantity(BC.status());
                    if(n!=0)
                        ItemsSingleton.addItem(n, BC.status(),false);
                    else
                        Console.WriteLine("A " + n + " db termék nem értelmezhető! Kérlek adj meg egy helyes mennyiséget!");
                    Thread.Sleep(1000);
                    managemenu();
                    break;
                    case '3':                        
                        QualityTomatoCan QTC = new QualityTomatoCan(TC);
                        n = inputQuantity(QTC.status());
                    if(n!=0)
                        ItemsSingleton.addItem(n, QTC.status(),true);
                    else
                        Console.WriteLine("A " + n + " db termék nem értelmezhető! Kérlek adj meg egy helyes mennyiséget!");
                    Thread.Sleep(1000);
                    managemenu();
                    break;
                    case '4':
                        QualityBeanCan QTB = new QualityBeanCan(BC);
                        n = inputQuantity(QTB.status());
                    if(n!=0)
                        ItemsSingleton.addItem(n, QTB.status(),true);
                    else
                        Console.WriteLine("A " + n + " db termék nem értelmezhető! Kérlek adj meg egy helyes mennyiséget!");
                    Thread.Sleep(1000);
                    managemenu();
                    break;
                        case '5':
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
        private int inputQuantity(string productName)
        {
            int n;
            try
            {                
                Console.Clear();
                Console.WriteLine("Add meg mennyi " + productName + " konzervet szeretnél rendelni!");
                n = Convert.ToInt32(Console.ReadLine());
                return n;
            }
            catch(Exception e)
            {
                Console.WriteLine("Nem számot adtál meg, nyomj egy gombot a folytatáshoz! - " + e.Message);
                Console.ReadLine();
            }
            return 0;
        }
        protected override void SetPrompt()
        {
            Prompt = "Ez az Rendelési management oldala. Itt tudsz árút rendelni. \nVálassz az alábbi lehetőségekből, add meg melyik terméket szeretnéd megrendelni!";
        }
        new List<string> Options = new List<string>();
        public override void SetOptions()
        {
            Console.Clear();            
            Options.Add("[1] Paradicsomos konzerv");
            Options.Add("[2] Bab konzerv");
            Options.Add("[3] Minőségi paradicsomos konzerv");
            Options.Add("[4] Minőségi bab konzerv");
            Options.Add("[5] Vissza");
            SetPrompt();
            Console.WriteLine(Prompt);
            
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine(Options[i]);
                
            }          
            Options.Clear();

        }
        
      
    }
}
