
namespace DonutsApp
{
    partial class frmOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblCoffees = new System.Windows.Forms.Label();
            this.lblDonuts = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCoffees = new System.Windows.Forms.TextBox();
            this.txtDonuts = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(56, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter your name: ";
            // 
            // lblCoffees
            // 
            this.lblCoffees.AutoSize = true;
            this.lblCoffees.Location = new System.Drawing.Point(56, 144);
            this.lblCoffees.Name = "lblCoffees";
            this.lblCoffees.Size = new System.Drawing.Size(112, 15);
            this.lblCoffees.TabIndex = 1;
            this.lblCoffees.Text = "Number of coffees: ";
            // 
            // lblDonuts
            // 
            this.lblDonuts.AutoSize = true;
            this.lblDonuts.Location = new System.Drawing.Point(58, 194);
            this.lblDonuts.Name = "lblDonuts";
            this.lblDonuts.Size = new System.Drawing.Size(111, 15);
            this.lblDonuts.TabIndex = 2;
            this.lblDonuts.Text = "Number of donuts: ";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(136, 261);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(99, 34);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(196, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 23);
            this.txtName.TabIndex = 4;
            // 
            // txtCoffees
            // 
            this.txtCoffees.Location = new System.Drawing.Point(196, 141);
            this.txtCoffees.Name = "txtCoffees";
            this.txtCoffees.Size = new System.Drawing.Size(158, 23);
            this.txtCoffees.TabIndex = 5;
            // 
            // txtDonuts
            // 
            this.txtDonuts.Location = new System.Drawing.Point(196, 191);
            this.txtDonuts.Name = "txtDonuts";
            this.txtDonuts.Size = new System.Drawing.Size(158, 23);
            this.txtDonuts.TabIndex = 6;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 337);
            this.Controls.Add(this.txtDonuts);
            this.Controls.Add(this.txtCoffees);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblDonuts);
            this.Controls.Add(this.lblCoffees);
            this.Controls.Add(this.lblName);
            this.Name = "frmOrder";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCoffees;
        private System.Windows.Forms.Label lblDonuts;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCoffees;
        private System.Windows.Forms.TextBox txtDonuts;
    }
}

