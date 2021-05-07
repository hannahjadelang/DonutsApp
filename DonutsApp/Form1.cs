using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Derived from GeeksforGeeks
// Author : Soumik Mondal
// Date : August 2019
// Website : https://www.geeksforgeeks.org/c-sharp-delegates/#:~:text=Delegates%20are%20the%20library%20class,called%20on%20a%20single%20event.

// Derived from : C# Corner
// Author : Vidya Vrat Agarwal
// Date : May 2019
// Website : https://www.c-sharpcorner.com/UploadFile/84c85b/delegates-and-events-C-Sharp-net/

namespace DonutsApp
{
    // 
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        // Event when user clicks "Place Order" button
        private void btnOrder_Click(object sender, EventArgs e)
        {
            // class fields assigned to form

            string name = txtName.Text;
            int coffees = Convert.ToInt32(txtCoffees.Text);
            int donuts = Convert.ToInt32(txtDonuts.Text);

            // instantiating MyOrder class and assigning data to this class
            MyOrder order = new MyOrder(name, coffees, donuts);

            // instantiating GenerateOrder worker class and assigning the delegate method
            GenerateOrder myOrder = new GenerateOrder();
            myOrder.TheOrder(order);

            // instantiating new object for MyOrder class to call ToString method
            MyOrder o = new MyOrder(name, coffees, donuts);
            MessageBox.Show(o.ToString());
        }
    }
}
