using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment.State
{
        class OrderedState : CanStatusState
        {
            public override void NextStatus(CanStatus canStatus)
            {
                canStatus.UpdateStatus("Rendelés feldolgozás alatt");
                canStatus.setState(new OrderProcessingState());
            }

            public OrderedState()
            {

            }

        }
}
