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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace FullBookstore
{
    public partial class CustomerList : Form
    {
        string name = "[^A-Za-z']";
        string phone = "^((1-([(][0-9]{3}[)]|[0-9]{3})-)[0-9]{3}-[0-9]{4})$";
        string email = "^[A-Z0-9._%+-]+@[A-Z0-9.-]+[.][A-Z]{2,4}$";
        string zip = @"^\d{5}(?:[-\s]\d{4})?$";
        public List<string> customerNames = new List<string>();
        public string SelectedItem; //keeps track of selected item from list
        public string tempfirst; //used to detect if first name being changed
        public string templast;//used to detect if last name being changed
        int newCustomerRequested = 0; //keeps track of new customer mode (1) or update mode (0)

        MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");



        public CustomerList()
        {
            InitializeComponent();
            try
            {
                populateComboBox();
                this.comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch
            {
                statusTextBox.Text = "Cannot connect to database.";
            }
        }
        private void populateComboBox()
        {
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");

            string selectedQuery = "SELECT * FROM bookstore.customers";
            connection.Open();
            MySqlCommand command = new MySqlCommand(selectedQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            comboBox.Items.Clear();
            while (reader.Read())
            {
                comboBox.Items.Add(reader.GetString("first") + " " + reader.GetString("last"));
            }
            connection.Close();
        }
        private Customer CreateCustomer()
        {
            Customer custo = new Customer();

            if (firstTextBox.Text == "" || Regex.IsMatch(firstTextBox.Text, name))
            {
                custo = null;

                MessageBox.Show("Please Enter First Name", "First Name is a required field");
                firstTextBox.Focus();
            }
            else if (lastTextBox.Text == "" || Regex.IsMatch(lastTextBox.Text, name))
            {
                custo = null;

                MessageBox.Show("Please Enter valid Last Name", "Last name is a required field");
                firstTextBox.Focus();
            }
            else if (PhoneTextBox.Text == "" || Regex.IsMatch(PhoneTextBox.Text, phone))
            {
                custo = null;

                MessageBox.Show("Please Enter valid 10 digit Phone Number e.g: xxxxxxxxxx", "First Name is a required field");
                firstTextBox.Focus();
            }
            else if (addressTextBox.Text == "" || Regex.IsMatch(addressTextBox.Text, zip))
            {
                custo = null;

                MessageBox.Show("Please Enter Valid Address", "Address is a required field");
                addressTextBox.Focus();
            }
            else if (stateTextBox.Text == "" || Regex.IsMatch(stateTextBox.Text, name))
            {
                custo = null;

                MessageBox.Show("Please enter Valid State", "State is a required field");
                stateTextBox.Focus();
            }
            else if (cityTextBox.Text == "")
            {
                custo = null;

                MessageBox.Show("Please enter valid city", "city is a required field");
                cityTextBox.Focus();
            }
            else if (zipTextBox.Text == "")
            {
                custo = null;

                MessageBox.Show("Please enter a valid 5 digit zip code", "Zip is a required field");
                zipTextBox.Focus();
            }
            else if (emailTextBox.Text == "" || Regex.IsMatch(emailTextBox.Text, email))
            {
                MessageBox.Show("Please enter a valid Email", "Email is a required field");
                custo = null;
                emailTextBox.Focus();
            }
            else
            {
                custo.first = firstTextBox.Text;
                custo.last = lastTextBox.Text;
                custo.address = addressTextBox.Text;
                custo.city = cityTextBox.Text;
                custo.state = stateTextBox.Text;
                custo.zip = zipTextBox.Text;
                custo.phone = PhoneTextBox.Text;
                custo.email = emailTextBox.Text;
            }


            return custo;
        }
        private int checkIfCustoExists(string custoName)
        { //simple function to check if current customer is in loaded list
            int result = 1;
            foreach (var name in customerNames)
            {
                if (name == custoName)
                    return 0;
            }
            return result;
        }
        private int countFinder()
        {
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");
            connection.Open();
            string command = $"SELECT COUNT(*) FROM bookstore.customers WHERE first = '{firstTextBox.Text}' AND last = '{lastTextBox.Text}'";
            MySqlCommand counter = new MySqlCommand(command, connection);
            int records = Convert.ToInt32((counter.ExecuteScalar()));

            connection.Close();

            //SELECT COUNT(*) FROM bookstore.books WHERE title LIKE %'African'
            return records;
        }
        void AddCustomer() //custoName = first + last
        {
            try
            {

                MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");

                int records = countFinder();
                if (records == 0)
                {
                    connection.Open();
                    string sql = $"INSERT IGNORE INTO bookstore.customers (first, last, address, city, state, zip, phone, email) VALUES ('{firstTextBox.Text}','{lastTextBox.Text}','{addressTextBox.Text}','{cityTextBox.Text}','{stateTextBox.Text}','{zipTextBox.Text}', '{PhoneTextBox.Text}','{emailTextBox.Text}')";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer successfully Created.");
                    ClearTextBoxes();
                    comboBox.Text = "Select customer from list to edit...";
                    comboBox.Enabled = true;
                    populateComboBox();
                }
                else
                {
                    MessageBox.Show("Customer already exists. Please select from combo box.");
                    ClearTextBoxes();
                    comboBox.Enabled = true;

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

        //string CreateCustomerJSON(string username, Customer newCustomer)
        //{
        //    //Create employee dictionary
        //    Dictionary<string, Customer> tempCustomer = new Dictionary<string, Customer>
        //        {
        //            { username, newCustomer }
        //        };

        //    //Make JSON string from dictionary
        //    return JsonConvert.SerializeObject(tempCustomer, Formatting.Indented);
        //}
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = (string)comboBox.SelectedItem;
            try
            {
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");

                SelectedItem = comboBox.SelectedItem.ToString();
                string[] name = SelectedItem.Split(null);

                string query = $"SELECT * FROM bookstore.customers WHERE first = \"{name[0]}\" AND last = \"{name[1]}\"";
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    firstTextBox.Text = reader["first"].ToString();
                    lastTextBox.Text = reader["last"].ToString();
                    addressTextBox.Text = reader["address"].ToString();
                    cityTextBox.Text = reader["city"].ToString();
                    stateTextBox.Text = reader["state"].ToString();
                    zipTextBox.Text = reader["zip"].ToString();
                    emailTextBox.Text = reader["email"].ToString();
                    PhoneTextBox.Text = reader["phone"].ToString();
                    tempfirst = reader["first"].ToString();
                    templast = reader["last"].ToString();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //clear form
                firstTextBox.Clear();
                lastTextBox.Clear();
                addressTextBox.Clear();
                cityTextBox.Clear();
                stateTextBox.Clear();
                zipTextBox.Clear();
                PhoneTextBox.Clear();
                //emailTextBox.Clear();
            }
            finally
            {
                connection.Close();
            }
            comboBox.Focus();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel adding new customer?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.comboBox.Enabled = true;
                newCustomerRequested = 0;
                ClearTextBoxes();
                MessageBox.Show("Your request has been cancelled.");
            }
            else if (dialogResult == DialogResult.No) { }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu store = new MainMenu();
            store.Show();
            Hide();
        }

        private void newCustomerButton_Click(object sender, EventArgs e)
        {
            this.comboBox.Enabled = false;
            newCustomerRequested = 1;
            ClearTextBoxes();

        }

        private void ClearTextBoxes() //Found on stack overflow
        {
            comboBox.SelectedIndex = -1;
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
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (newCustomerRequested == 1)
            {
                this.comboBox.Enabled = false;
                AddCustomer();
                populateComboBox();

            }
            else if (newCustomerRequested == 0)
            {
                this.comboBox.Enabled = true;

                if (firstTextBox.Text == "" || Regex.IsMatch(firstTextBox.Text, name))
                {

                    MessageBox.Show("Please Enter First Name", "First Name is a required field");
                    firstTextBox.Focus();
                }
                else if (lastTextBox.Text == "" || Regex.IsMatch(lastTextBox.Text, name))
                {

                    MessageBox.Show("Please Enter Last Name", "Last name is a required field");
                    firstTextBox.Focus();
                }
                else if (PhoneTextBox.Text == "" || Regex.IsMatch(PhoneTextBox.Text, phone))
                {

                    MessageBox.Show("Please Enter Phone Number", "First Name is a required field");
                    firstTextBox.Focus();
                }
                else if (addressTextBox.Text == "" || Regex.IsMatch(addressTextBox.Text, zip))
                {
                    MessageBox.Show("Please Enter Address", "Address is a required field");
                    addressTextBox.Focus();
                }
                else if (stateTextBox.Text == "" || Regex.IsMatch(stateTextBox.Text, name))
                {

                    MessageBox.Show("Please Enter State", "State is a required field");
                    stateTextBox.Focus();
                }
                else if (cityTextBox.Text == "")
                {

                    MessageBox.Show("Please Enter city", "city is a required field");
                    cityTextBox.Focus();
                }
                else if (zipTextBox.Text == "")
                {

                    MessageBox.Show("Please Enter Zip", "Zip is a required field");
                    zipTextBox.Focus();
                }
                else if (emailTextBox.Text == "" || Regex.IsMatch(emailTextBox.Text, email))
                {
                    MessageBox.Show("Please Enter Email", "Email is a required field");
                    emailTextBox.Focus();
                }
                else
                {

                    if (SelectedItem is null)
                    {
                        MessageBox.Show("Please select customer from list", "Save Error");
                        return;
                    }
                    try
                    {
                        string MyConnection2 = "Datasource=localhost;port=3306;username=root;password=";

                        string Query = $"UPDATE bookstore.customers SET first = '{firstTextBox.Text}', last = '{lastTextBox.Text}', address = '{addressTextBox.Text}', " +
                            $"city = '{cityTextBox.Text}', state = '{stateTextBox.Text}', zip = '{zipTextBox.Text}', phone = '{PhoneTextBox.Text}', email = '{emailTextBox.Text}'  " +
                            $"WHERE first = '{firstTextBox.Text}' AND last = '{lastTextBox.Text}'";

                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                        MyConn2.Open();

                        if (MyCommand2.ExecuteNonQuery() == 1 && tempfirst == firstTextBox.Text && templast == lastTextBox.Text)
                            MessageBox.Show("Customer Updated Successfully");
                        else
                            MessageBox.Show("Not updated, Are you trying to update first or last name?");
                        populateComboBox();
                        MyConn2.Close();//Connection closed here 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClearTextBoxes();

                    statusTextBox.Text = "Customer Info Updated Successfully";
                }
            }
            this.comboBox.Enabled = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}