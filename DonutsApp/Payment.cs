using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DonutsApp
{
    class Payment
    {
        // Creating seperate method for seperate class to call as delegate
        public void GetPayment(MyOrder order)
        {
            MessageBox.Show("Payment from : " + order.Name);
        }
    }
}
