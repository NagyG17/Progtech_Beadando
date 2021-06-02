using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu FoMenu = new MainMenu();
            FoMenu.drawMenu();

            char mench;
            mench = Console.ReadKey().KeyChar;
            if (mench == '1')
            {
                OrderMenu OrManMenu = new OrderMenu();
                OrManMenu.drawMenu();
            }
            else
            {
                Console.WriteLine("Nem jó menüt választottál");
            }
        }
    }
}
