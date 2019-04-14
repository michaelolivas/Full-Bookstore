using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FullBookstore
{
    public partial class Bookstore : Form
    {
        public const Double tax = .1;
        public Double subTotal = 0;
        public Bookstore()
        {
            InitializeComponent();
            this.AutoSize = true; //resize auto
            this.dataGridView1.AllowUserToAddRows = false; //disable user changes

            try
            {
                populateComboBox();
                populateComboBox2();
            }
            catch
            {
                TotalText.Text = "Check db Connection";
            }

        }

        public void AddTitle_Click(object sender, EventArgs e)
        {
            //get title of book
            try
            {
                int Quantity;
                bool Qty = int.TryParse(QuantityText.Text, out Quantity); //grab number input
                if (Qty && Quantity != 0 && !(Quantity < 0)) //handle exception 0 and negative numbers
                {
                    decimal totalCost = Quantity * Convert.ToDecimal(PriceText.Text);//Get the total
                    // Populate the rows.
                    string selectedItem = (string)comboBox1.SelectedItem;
                    string[] row = new string[] { selectedItem, PriceText.Text, Quantity.ToString(), totalCost.ToString() };//populate and add row
                                                                                                                            //populate dataGridView upon click Add Title
                    dataGridView1.Rows.Add(row);
                    subTotal += Quantity * Convert.ToDouble(PriceText.Text); //add total
                    Subtotal_Text.Text = Math.Round(subTotal, 2).ToString();
                    TaxText.Text = (Math.Round(subTotal * tax, 2)).ToString();
                    TotalText.Text = (Math.Round((subTotal * tax) + subTotal, 2)).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number");
                    QuantityText.Focus();//cursor on field
                }
            }
            catch
            {

                MessageBox.Show("Please select a book from the list.");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //event handle when picking an item
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");

                string selectedItem = $"\"{comboBox1.SelectedItem.ToString()}\"";
                string query = "SELECT * FROM bookstore.books WHERE title = " + selectedItem;
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    AuthorText.Text = reader["author"].ToString();
                    PriceText.Text = reader["price"].ToString();
                    IsbnText.Text = reader["ISBN"].ToString();

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //clear form
                AuthorText.Clear();
                IsbnText.Clear();
                PriceText.Clear();

            }

            QuantityText.Focus();
        }

        void populateComboBox()
        {

            MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");

            string selectedQuery = "SELECT * FROM bookstore.books";
            connection.Open();
            MySqlCommand command = new MySqlCommand(selectedQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString("title"));
            }
            connection.Close();

        }
        private void populateComboBox2()
        {
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");

            string selectedQuery = "SELECT * FROM bookstore.customers";
            connection.Open();
            MySqlCommand command = new MySqlCommand(selectedQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            comboBox2.Items.Clear();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader.GetString("first") + " " + reader.GetString("last"));
            }
            connection.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuantityText_TextChanged(object sender, EventArgs e)
        {
        }

        private void TotalText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmOrderButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {//means nothing was added
                MessageBox.Show("Please add a book to check out.");
            }
            else
            {//populate receipt
                string customer, title;
                double price, total, subtotal;
                string dateTimeString = DateTime.Now.ToString("yyyy’-‘MM’-‘dd’HH’:’mm’:’ss");
                Dictionary<string, string> order = new Dictionary<string, string>();
                List<string> info = new List<string>();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    info.Clear();

                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        info.Add(dataGridView1[j, i].Value.ToString());
                    }
                    customer = selectedCustomer; //add to SQL here
                    title = info[0];
                    price = System.Convert.ToDouble(info[1]);
                    bool quantity = int.TryParse(info[2], out int qty);
                    subtotal = qty * System.Convert.ToDouble(info[1]);
                    total = (0.17 * subtotal + subtotal);
                    total = Math.Round(total, 2);
                    MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");

                    connection.Open();
                    string sql = $"INSERT IGNORE INTO bookstore.orders (customer,title,price,qty,subtotal,total,datetime) VALUES ('{customer}','{title}','{price.ToString()}','{qty.ToString()}','{subtotal.ToString()}','{total.ToString()}', NOW())";
                    string tempQuery = sql;
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(sql, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                MessageBox.Show("Thank you! Your order has been placed!");

                dataGridView1.Rows.Clear(); //clear fields
                ClearTextBoxes();//clear boxes
            }
        }

        private void ClearTextBoxes() //Found on stack overflow
        {
            comboBox1.Text = "";
            comboBox1.SelectedValue = "";
            comboBox2.Text = "";
            comboBox2.SelectedValue = "";

            Action<Control.ControlCollection> func = null;

            func = (controls) =>//lambda expression
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel your order?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                ClearTextBoxes();
                MessageBox.Show("Your order has been cancelled.");
            }
            else if (dialogResult == DialogResult.No) { }

        }

        private void BookStoreGUI_Load(object sender, EventArgs e)
        {

        }

        private void AuthorLabel_Click(object sender, EventArgs e)
        {

        }

        private void AuthorText_TextChanged(object sender, EventArgs e)
        {

        }

        private void IsbnText_TextChanged(object sender, EventArgs e)
        {

        }

        private void IsbnLabel_Click(object sender, EventArgs e)
        {

        }

        private void OrderSummaryLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Menu store = new Menu();
            store.Show();
            Hide();
        }
        string selectedCustomer;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedCustomer = comboBox2.SelectedItem.ToString();
            }
            catch
            {
                selectedCustomer = "";
            }
        }
    }
}