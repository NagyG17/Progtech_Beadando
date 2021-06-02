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
            OrderMenu OMenu = new OrderMenu();
            ProductMenu PMenu = new ProductMenu();
            SupplierAndCustomerMenu SACMenu = new SupplierAndCustomerMenu();
            FoMenu.SetOptions();
            
            FoMenu.managemenu();

            
            /*char menuchar=' ';
            switch (FoMenu.setChar(menuchar))
            {
                case '1':
                    OMenu.SetOptions();
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
            }*/
          /*  switch (FoMenu.setChar(menuchar) == '1')
            {
                OrderMenu OrManMenu = new OrderMenu();
                OrManMenu.SetOptions();
                //mench = ' ';
            }
            else
            {
                Console.WriteLine("Nem jó menüt választottál");
            }*/
        }
    }
}
