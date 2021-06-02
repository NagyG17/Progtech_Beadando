using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment
{
    class OrderMenu : MenuBase
    {
        protected override void SetPrompt()
        {
            Prompt = "Ez az Order Management oldala. \nVálassz az alábbi lehetőségekből!";
        }


        protected override void SetOptions()
        {
            Options = new List<String>();
            Options.Add("[1] Rendelés");
            Options.Add("[2] Sex");
            Options.Add("[3] Mégse sex");
            Options.Add("[4] Exit");
        }

        public override void drawMenu()
        {
            Console.Clear();
            SetPrompt();
            Console.WriteLine(Prompt);
            SetOptions();
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine(Options[i]);
            }
        }
    }
}
