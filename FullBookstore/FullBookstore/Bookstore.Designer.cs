namespace FullBookstore
{
    partial class Bookstore
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
            this.AddTitle = new System.Windows.Forms.Button();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.IsbnLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.OrderSummaryLabel = new System.Windows.Forms.Label();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.Subtotal_Text = new System.Windows.Forms.TextBox();
            this.TaxText = new System.Windows.Forms.TextBox();
            this.TotalText = new System.Windows.Forms.TextBox();
            this.ConfirmOrderButton = new System.Windows.Forms.Button();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.AuthorText = new System.Windows.Forms.TextBox();
            this.IsbnText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTitle
            // 
            this.AddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddTitle.Location = new System.Drawing.Point(562, 139);
            this.AddTitle.Name = "AddTitle";
            this.AddTitle.Size = new System.Drawing.Size(103, 47);
            this.AddTitle.TabIndex = 0;
            this.AddTitle.Text = "Add Title";
            this.AddTitle.UseVisualStyleBackColor = true;
            this.AddTitle.Click += new System.EventHandler(this.AddTitle_Click);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(79, 131);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.AuthorLabel.TabIndex = 1;
            this.AuthorLabel.Text = "Author:";
            this.AuthorLabel.Click += new System.EventHandler(this.AuthorLabel_Click);
            // 
            // IsbnLabel
            // 
            this.IsbnLabel.AutoSize = true;
            this.IsbnLabel.Location = new System.Drawing.Point(78, 210);
            this.IsbnLabel.Name = "IsbnLabel";
            this.IsbnLabel.Size = new System.Drawing.Size(35, 13);
            this.IsbnLabel.TabIndex = 2;
            this.IsbnLabel.Text = "ISBN:";
            this.IsbnLabel.Click += new System.EventHandler(this.IsbnLabel_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(79, 172);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(34, 13);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Price:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(428, 157);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(49, 13);
            this.QuantityLabel.TabIndex = 4;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // OrderSummaryLabel
            // 
            this.OrderSummaryLabel.AutoSize = true;
            this.OrderSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSummaryLabel.Location = new System.Drawing.Point(313, 232);
            this.OrderSummaryLabel.Name = "OrderSummaryLabel";
            this.OrderSummaryLabel.Size = new System.Drawing.Size(205, 31);
            this.OrderSummaryLabel.TabIndex = 5;
            this.OrderSummaryLabel.Text = "Order Summary";
            this.OrderSummaryLabel.Click += new System.EventHandler(this.OrderSummaryLabel_Click);
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SubtotalLabel.Location = new System.Drawing.Point(49, 429);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(90, 25);
            this.SubtotalLabel.TabIndex = 6;
            this.SubtotalLabel.Text = "Subtotal:";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TaxLabel.Location = new System.Drawing.Point(292, 429);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(52, 25);
            this.TaxLabel.TabIndex = 7;
            this.TaxLabel.Text = "Tax:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TotalLabel.Location = new System.Drawing.Point(503, 429);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(62, 25);
            this.TotalLabel.TabIndex = 8;
            this.TotalLabel.Text = "Total:";
            // 
            // Subtotal_Text
            // 
            this.Subtotal_Text.Location = new System.Drawing.Point(145, 433);
            this.Subtotal_Text.Name = "Subtotal_Text";
            this.Subtotal_Text.ReadOnly = true;
            this.Subtotal_Text.Size = new System.Drawing.Size(100, 20);
            this.Subtotal_Text.TabIndex = 9;
            // 
            // TaxText
            // 
            this.TaxText.Location = new System.Drawing.Point(350, 433);
            this.TaxText.Name = "TaxText";
            this.TaxText.ReadOnly = true;
            this.TaxText.Size = new System.Drawing.Size(100, 20);
            this.TaxText.TabIndex = 10;
            // 
            // TotalText
            // 
            this.TotalText.Location = new System.Drawing.Point(571, 433);
            this.TotalText.Name = "TotalText";
            this.TotalText.ReadOnly = true;
            this.TotalText.Size = new System.Drawing.Size(111, 20);
            this.TotalText.TabIndex = 11;
            this.TotalText.TextChanged += new System.EventHandler(this.TotalText_TextChanged);
            // 
            // ConfirmOrderButton
            // 
            this.ConfirmOrderButton.Location = new System.Drawing.Point(252, 496);
            this.ConfirmOrderButton.Name = "ConfirmOrderButton";
            this.ConfirmOrderButton.Size = new System.Drawing.Size(140, 34);
            this.ConfirmOrderButton.TabIndex = 12;
            this.ConfirmOrderButton.Text = "Confirm Order";
            this.ConfirmOrderButton.UseVisualStyleBackColor = true;
            this.ConfirmOrderButton.Click += new System.EventHandler(this.ConfirmOrderButton_Click);
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.Location = new System.Drawing.Point(411, 496);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(154, 34);
            this.CancelOrderButton.TabIndex = 13;
            this.CancelOrderButton.Text = "Cancel Order";
            this.CancelOrderButton.UseVisualStyleBackColor = true;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // AuthorText
            // 
            this.AuthorText.Location = new System.Drawing.Point(125, 128);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.ReadOnly = true;
            this.AuthorText.Size = new System.Drawing.Size(120, 20);
            this.AuthorText.TabIndex = 14;
            this.AuthorText.TextChanged += new System.EventHandler(this.AuthorText_TextChanged);
            // 
            // IsbnText
            // 
            this.IsbnText.Location = new System.Drawing.Point(125, 208);
            this.IsbnText.Name = "IsbnText";
            this.IsbnText.ReadOnly = true;
            this.IsbnText.Size = new System.Drawing.Size(120, 20);
            this.IsbnText.TabIndex = 15;
            this.IsbnText.TextChanged += new System.EventHandler(this.IsbnText_TextChanged);
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(125, 169);
            this.PriceText.Name = "PriceText";
            this.PriceText.ReadOnly = true;
            this.PriceText.Size = new System.Drawing.Size(120, 20);
            this.PriceText.TabIndex = 16;
            // 
            // QuantityText
            // 
            this.QuantityText.Location = new System.Drawing.Point(483, 154);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(51, 20);
            this.QuantityText.TabIndex = 17;
            this.QuantityText.TextChanged += new System.EventHandler(this.QuantityText_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Price,
            this.Quantity,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(30, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 116);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "QTY";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Location = new System.Drawing.Point(206, 65);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(468, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(722, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Select Book";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 13;
            this.comboBox2.Location = new System.Drawing.Point(206, 21);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(226, 21);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 23;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Select Customer";
            // 
            // BookStoreGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 567);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.QuantityText);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.IsbnText);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.CancelOrderButton);
            this.Controls.Add(this.ConfirmOrderButton);
            this.Controls.Add(this.TotalText);
            this.Controls.Add(this.TaxText);
            this.Controls.Add(this.Subtotal_Text);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.SubtotalLabel);
            this.Controls.Add(this.OrderSummaryLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.IsbnLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.AddTitle);
            this.MinimumSize = new System.Drawing.Size(825, 580);
            this.Name = "BookStoreGUI";
            this.Text = "5";
            this.Load += new System.EventHandler(this.BookStoreGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTitle;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label IsbnLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label OrderSummaryLabel;
        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox Subtotal_Text;
        private System.Windows.Forms.TextBox TaxText;
        private System.Windows.Forms.TextBox TotalText;
        private System.Windows.Forms.Button ConfirmOrderButton;
        private System.Windows.Forms.Button CancelOrderButton;
        private System.Windows.Forms.TextBox AuthorText;
        private System.Windows.Forms.TextBox IsbnText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
    }
}
