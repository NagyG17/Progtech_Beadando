using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment
{
    abstract class MenuBase
    {
        protected string Prompt;
        abstract protected void SetPrompt();


        protected List<String> Options;
        abstract protected void SetOptions();

        abstract public void drawMenu();
    }
}
