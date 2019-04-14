using System;
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
    public partial class Booklist : Form
    {
        MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");
        string selectedItem = "";
        int newBookRequested = 0;
        string tempTitle = "";

        public Booklist()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");

                selectedItem = $"\"{comboBox1.SelectedItem.ToString()}\"";
                string query = "SELECT * FROM bookstore.books WHERE title = " + selectedItem;
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBoxTitle.Text = reader["title"].ToString();
                    textBoxAuthor.Text = reader["author"].ToString();
                    textBoxISBN.Text = reader["ISBN"].ToString();
                    textBoxPrice.Text = reader["price"].ToString();
                    tempTitle = reader["title"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LabelISBN_Click(object sender, EventArgs e)
        {

        }

        private void textBoxISBN_TextChanged(object sender, EventArgs e)
        {

        }
        private void load_combo()
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
        private void BookManager_Load(object sender, EventArgs e)
        {
            try
            {
                load_combo();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }

        }

        private void buttonNewBook_Click(object sender, EventArgs e)
        {
            this.comboBox1.Enabled = false;
            newBookRequested = 1;
            ClearTextBoxes();
        }
        private void ClearTextBoxes() //Found on stack overflow
        {
            comboBox1.Text = "";
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (newBookRequested == 1)
            {
                createNewBook();
                newBookRequested = 0;
            }
            else if (newBookRequested == 0)
            {
                updateSelectedBook();
                newBookRequested = 0;
            }

        }
        private int countFinder()
        {
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");
            connection.Open();
            string command = $"SELECT COUNT(*) FROM bookstore.books WHERE title = '{textBoxTitle.Text}'";
            MySqlCommand counter = new MySqlCommand(command, connection);
            int records = Convert.ToInt32((counter.ExecuteScalar()));

            connection.Close();

            //SELECT COUNT(*) FROM bookstore.books WHERE title LIKE %'African'
            return records;
        }
        private void createNewBook()
        {
            try
            {

                MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");

                //string selectedQuery = "SELECT * FROM bookstore.books";
                int records = countFinder();
                if (records == 0)
                {
                    connection.Open();
                    string sql = $"INSERT IGNORE INTO bookstore.books (title, author, ISBN, price) VALUES ('{textBoxTitle.Text}','{textBoxAuthor.Text}', '{textBoxISBN.Text}','{textBoxPrice.Text}')";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Successfully Created.");
                    ClearTextBoxes();
                    comboBox1.Text = "Select book from list to edit...";
                    comboBox1.Enabled = true;
                    load_combo();
                }
                else
                {
                    MessageBox.Show("Book already exists. Please select from combo box.");
                    ClearTextBoxes();
                    comboBox1.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void updateSelectedBook()
        {
            try
            {
                string MyConnection2 = "Datasource=localhost;port=3306;username=root;password=";

                string Query = $"UPDATE bookstore.books SET title = '{textBoxTitle.Text}', author = '{textBoxAuthor.Text}', ISBN = '{textBoxISBN.Text}', price = '{textBoxPrice.Text}' WHERE title = '{textBoxTitle.Text}'";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MyConn2.Open();

                if (MyCommand2.ExecuteNonQuery() == 1 && tempTitle == textBoxTitle.Text)
                    MessageBox.Show("Data Updated");
                else
                    MessageBox.Show("Not updated, Are you trying to update title?");
                load_combo();
                MyConn2.Close();//Connection closed here 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel adding new book?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.comboBox1.Enabled = true;
                newBookRequested = 0;
                ClearTextBoxes();
                MessageBox.Show("Your request has been cancelled.");
            }
            else if (dialogResult == DialogResult.No) { }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Menu store = new Menu();
            store.Show();
            Hide();
        }
    }
}