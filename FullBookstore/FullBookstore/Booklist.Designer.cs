namespace FullBookstore
{
    partial class Booklist
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.LabelISBN = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNewBook = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(569, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Edit an Existing Book";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(29, 69);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(30, 13);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Title:";
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.LabelAuthor.Location = new System.Drawing.Point(29, 118);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(41, 13);
            this.LabelAuthor.TabIndex = 2;
            this.LabelAuthor.Text = "Author:";
            // 
            // LabelISBN
            // 
            this.LabelISBN.AutoSize = true;
            this.LabelISBN.Location = new System.Drawing.Point(29, 160);
            this.LabelISBN.Name = "LabelISBN";
            this.LabelISBN.Size = new System.Drawing.Size(35, 13);
            this.LabelISBN.TabIndex = 3;
            this.LabelISBN.Text = "ISBN:";
            this.LabelISBN.Click += new System.EventHandler(this.LabelISBN_Click);
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(29, 205);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(34, 13);
            this.LabelPrice.TabIndex = 4;
            this.LabelPrice.Text = "Price:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(76, 61);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(569, 20);
            this.textBoxTitle.TabIndex = 5;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(76, 111);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(322, 20);
            this.textBoxAuthor.TabIndex = 6;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(76, 157);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(322, 20);
            this.textBoxISBN.TabIndex = 7;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.textBoxISBN_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(76, 202);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(168, 20);
            this.textBoxPrice.TabIndex = 8;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(679, 13);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(109, 23);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNewBook
            // 
            this.buttonNewBook.Location = new System.Drawing.Point(679, 69);
            this.buttonNewBook.Name = "buttonNewBook";
            this.buttonNewBook.Size = new System.Drawing.Size(109, 23);
            this.buttonNewBook.TabIndex = 10;
            this.buttonNewBook.Text = "New Book";
            this.buttonNewBook.UseVisualStyleBackColor = true;
            this.buttonNewBook.Click += new System.EventHandler(this.buttonNewBook_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(679, 118);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(109, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(679, 170);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(109, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // BookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNewBook);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelISBN);
            this.Controls.Add(this.LabelAuthor);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.comboBox1);
            this.Name = "BookManager";
            this.Text = "BookManager";
            this.Load += new System.EventHandler(this.BookManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.Label LabelISBN;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNewBook;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}