using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment.State
{
    class OrderTransportState : CanStatusState
    {
        public override void NextStatus(CanStatus canStatus)
        {
            canStatus.UpdateStatus("Rendelés kiszállítva");
            canStatus.setState(new OrderReadyState());
        }

        public OrderTransportState()
        {

        }
    }
}
