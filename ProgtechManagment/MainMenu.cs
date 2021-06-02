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

        
        protected override void SetOptions()
        {
            Options = new List<String>();
            Options.Add("[1] Order Management");
            Options.Add("[2] Product Management");
            Options.Add("[3] Exit");
        }

        public override void drawMenu()
        {
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
