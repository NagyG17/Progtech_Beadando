using System;
using System.Collections.Generic;
using System.Text;

namespace ProgtechManagment.State
{
    class CanStatus
    {
        private CanStatusState state;
        private int orderId;
        PlushOrders canOrders = new CanOrders();
        public void setState(CanStatusState state)
        {
            this.state = state;
        }

        public void NextStatus()
        {
            state.NextStatus(this);
        }

        public void UpdateStatus(string newStatusName)
        {
            canOrders.UpdateOrderStatus(orderId, newStatusName);
        }

        public CanStatus(CanStatusState state, int orderId)
        {
            this.state = state;
            this.orderId = orderId;
        }
    }
}
