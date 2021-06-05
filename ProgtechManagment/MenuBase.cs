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
        abstract public void SetOptions();
        public abstract void managemenu();
        
       
    }
}
