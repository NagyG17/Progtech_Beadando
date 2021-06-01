using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment.State
{
    class OrderPreparationState : CanStatusState
    {
        public override void NextStatus(CanStatus canStatus)
        {
            canStatus.UpdateStatus("Rendelés csomagolása");
            canStatus.setState(new OrderPackingState());
        }

        public OrderPreparationState()
        {

        }
    }
}
