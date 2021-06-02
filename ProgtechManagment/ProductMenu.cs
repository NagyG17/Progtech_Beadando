using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment
{
    class ProductMenu:MenuBase
    {
        protected override void SetPrompt()
        {
            Prompt = "Product management felület";
        }

        public override void managemenu() { }

        List<string> Options = new List<string>();
        public override void SetOptions()
        {
            Console.Clear();
            Options.Add("[1] Valami");
            Options.Add("[2] Zegz");
            Options.Add("[3] KLYZS");
            Options.Add("[4] Exit");
           
        }
    }
}
