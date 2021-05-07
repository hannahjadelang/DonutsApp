using System;
using System.Collections.Generic;
using System.Text;

namespace DonutsApp
{
    class GenerateOrder
    {
        // creating delegate for all usable methods
        public delegate void OrderProcessing(MyOrder order);

        // creating event for the delegate to take place
        public event OrderProcessing OrderPlaced;

        // method to instantiate working classes' objects
        public void TheOrder(MyOrder order)
        {
            CoffeeClass c = new CoffeeClass();
            DonutClass d = new DonutClass();
            Payment p = new Payment();

            // objects are assigned to event 
            OrderPlaced += c.MakeCoffee;
            OrderPlaced += d.PackDonuts;
            OrderPlaced += p.GetPayment;

            // event method called
            WhenOrderSubmitted(order);
        }

        // event method created to ensure the event has something to call
        protected virtual void WhenOrderSubmitted(MyOrder order)
        {
            if (OrderPlaced != null)
            {
                OrderPlaced(order);
            }
        }
    }
}
