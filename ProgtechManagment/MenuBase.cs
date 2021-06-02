using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment
{
    abstract class MenuBase
    {
        protected string Prompt;
        abstract protected void SetPrompt();
        //protected int SelectedIndex;
        protected List<String> Options;
        abstract public void SetOptions();
        public abstract void managemenu();
        
        /*public void drawMenu(List<string> list)
        {
            SetPrompt();
            Console.WriteLine(Prompt);
            //SetOptions();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
               // if (i == list.Count) { return; }
            }
        }*/
    }
}
