namespace FullBookstore
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonManageCustomers = new System.Windows.Forms.Button();
            this.buttonManageBooks = new System.Windows.Forms.Button();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonManageCustomers
            // 
            this.buttonManageCustomers.Location = new System.Drawing.Point(316, 147);
            this.buttonManageCustomers.Name = "buttonManageCustomers";
            this.buttonManageCustomers.Size = new System.Drawing.Size(169, 23);
            this.buttonManageCustomers.TabIndex = 0;
            this.buttonManageCustomers.Text = "Manage Customers";
            this.buttonManageCustomers.UseVisualStyleBackColor = true;
            this.buttonManageCustomers.Click += new System.EventHandler(this.buttonManageCustomers_Click);
            // 
            // buttonManageBooks
            // 
            this.buttonManageBooks.Location = new System.Drawing.Point(316, 200);
            this.buttonManageBooks.Name = "buttonManageBooks";
            this.buttonManageBooks.Size = new System.Drawing.Size(169, 23);
            this.buttonManageBooks.TabIndex = 1;
            this.buttonManageBooks.Text = "Manage Books";
            this.buttonManageBooks.UseVisualStyleBackColor = true;
            this.buttonManageBooks.Click += new System.EventHandler(this.buttonManageBooks_Click);
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.Location = new System.Drawing.Point(316, 253);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(169, 23);
            this.buttonPlaceOrder.TabIndex = 2;
            this.buttonPlaceOrder.Text = "Place Order";
            this.buttonPlaceOrder.UseVisualStyleBackColor = true;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 55);
            this.label2.TabIndex = 21;
            this.label2.Text = "Welcome to Book Store";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPlaceOrder);
            this.Controls.Add(this.buttonManageBooks);
            this.Controls.Add(this.buttonManageCustomers);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonManageCustomers;
        private System.Windows.Forms.Button buttonManageBooks;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.Label label2;
    }
}

