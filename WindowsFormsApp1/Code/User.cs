using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class User
    {
        private int id;
        private string fname;
        private string lname;
        private string street;
        private int city;
        private string phone;
        private string note;
        private int discount;
        private string sub;
        private string email;
        private int debt;

        public User(int id, string fname, string lname, string street, int city, string phone, string note, int discount, string sub, string email, int debt)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.street = street;
            this.city = city;
            this.phone = phone;
            this.note = note;
            this.discount = discount;
            this.sub = sub;
            this.email = email;
            this.debt = debt;
        }
        public User(string fname, string lname, string street, int city, string phone, string note, int discount, string sub, string email, int debt)
        {
            this.fname = fname;
            this.lname = lname;
            this.street = street;
            this.city = city;
            this.phone = phone;
            this.note = note;
            this.discount = discount;
            this.sub = sub;
            this.email = email;
            this.debt = debt;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Fname
        {
            get { return this.fname; }
            set { this.fname = value; }
        }
        public string LName
        {
            get { return this.lname; }
            set { this.lname = value; }
        }
        public string Street
        {
            get { return this.street; }
            set { this.street = value; }
        }
        public int City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public string Note
        {
            get { return this.note; }
            set { this.note = value; }
        }
        public int Discount
        {
            get { return this.discount; }
            set { this.discount = value; }
        }
        public string Sub
        {
            get { return this.sub; }
            set { this.sub = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public int Debt
        {
            get { return this.debt; }
            set { this.debt = value; }
        }
    }
}
