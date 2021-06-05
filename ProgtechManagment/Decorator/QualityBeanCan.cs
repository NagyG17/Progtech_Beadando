using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment.Decorator
{
    class QualityBeanCan:CanBaseDecorator
    {
        public override string status()
        {
            return "Minőségi " + base.status();
        }
        public QualityBeanCan(CanBase canBase):base(canBase)
        {

        }
    }
}
