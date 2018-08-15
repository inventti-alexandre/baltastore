using System;
using System.Collections.Generic;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Order
    {
        public Customer Customer { get; private set; }
        public int Number { get; private set; }
        public DateTime CreateDate { get; private set; }
        public string Status { get; private set; }
        public IList<OrderItem> items { get; private set; }
        public IList<Delivery> Deliveries { get; private set; }

        //to place an order
        public void Place()
        {

        }
    }
}