using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment.State
{
    class OrderReadyState : CanStatusState
    {
        public override void NextStatus(CanStatus canStatus)
        {
            canStatus.setState(new OrderReadyState());
        }

        public OrderReadyState()
        {

        }
    }
}
