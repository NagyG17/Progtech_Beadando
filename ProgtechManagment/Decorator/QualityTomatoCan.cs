using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment.Decorator
{
    class QualityTomatoCan:TomatoCan
    {
        public override string status()
        {
            return "Minőségi" + status();
        }
    }
}
