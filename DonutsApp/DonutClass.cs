using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonutsApp
{
    class DonutClass
    {
        // Creating seperate method for seperate class to call as delegate
        public void PackDonuts(MyOrder order)
        {
            MessageBox.Show("Number of donuts : " + order.Donuts);
        }
    }
}
