using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment.State
{
    class CanStatusState
    {
        abstract class CanStatusState
        {
            public abstract void NextStatus(CanStatus canStatus);
        }
    }
}
