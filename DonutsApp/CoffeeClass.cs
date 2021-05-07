using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonutsApp
{
    class CoffeeClass     
    {
        // MakeCoffee method with the MyOrder class object
        public void MakeCoffee(MyOrder order)
        {
            MessageBox.Show("Coffees to make : " + order.Coffees);
        }
    }
}
