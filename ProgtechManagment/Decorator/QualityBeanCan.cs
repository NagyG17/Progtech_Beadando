using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment.Decorator
{
    class QualityBeanCan:BeanCan
    {
        public override string status()
        {
            return "Minőségi" + status();
        }
    }
}
