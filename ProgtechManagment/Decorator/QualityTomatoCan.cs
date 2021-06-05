using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment.Decorator
{
    class QualityTomatoCan:CanBaseDecorator
    {
        public override string status()
        {
            return "Minőségi " + base.status();
        }
        public QualityTomatoCan(CanBase canBase):base(canBase)
        {

        }
    }
}
