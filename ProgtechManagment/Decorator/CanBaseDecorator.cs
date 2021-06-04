using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment.Decorator
{
   abstract class CanBaseDecorator:CanBase
    {
        private CanBase canBase;

        public override string status()
        {
            return canBase.status();
        }

        public CanBaseDecorator(CanBase canBase)
        {
            this.canBase = canBase;
        }
    }
}
