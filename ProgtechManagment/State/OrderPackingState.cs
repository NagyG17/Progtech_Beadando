using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment.State
{
    class OrderPackingState : CanStatusState
    {
        public override void NextStatus(CanStatus canStatus)
        {
            canStatus.UpdateStatus("Rendelés kiszállítás alatt");
            canStatus.setState(new OrderTransportState());
        }

        public OrderPackingState()
        {

        }
    }
}
