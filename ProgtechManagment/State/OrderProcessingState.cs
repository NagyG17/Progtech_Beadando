using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment.State
{
    class OrderProcessingState : CanStatusState
    {
        public override void NextStatus(CanStatus canStatus)
        {
            canStatus.UpdateStatus("Rendelés elokészítés");
            canStatus.setState(new OrderPreparationState());
        }

        public OrderProcessingState()
        {

        }
    }
}
