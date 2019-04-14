using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullBookstore
{
    class Customer
    {
        public string first { get; set; }
        public string last { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public Customer(string first, string last, string address, string city, string state, string zip, string phone, string email)
        {
            this.first = first;
            this.last = last;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone = phone;
            this.email = email;
        }
        public Customer()
        {
            this.first = null;
            this.last = null;
            this.city = null;
            this.state = null;
            this.zip = null;
            this.phone = null;
            this.email = null;
        }
    }
}
