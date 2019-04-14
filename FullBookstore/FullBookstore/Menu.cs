using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullBookstore
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void buttonManageCustomers_Click(object sender, EventArgs e)
        {
            CustomerList store = new CustomerList();
            store.Show();
            Hide();
        }

        private void buttonManageBooks_Click(object sender, EventArgs e)
        {
            Booklist store = new Booklist();
            store.Show();
            Hide();
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            Bookstore store = new Bookstore();
            store.Show();
            Hide();
        }
    }
}
