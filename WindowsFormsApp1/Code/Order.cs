using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Order
    {
        private int id;
        private int o;
        private int desc;
        private int color;
        private DateTime date;
        private int amount;
        private int price;
        private string cab;
        private string status;
        private DateTime finish;
        private DateTime delivered;
        private int paid;
        private bool full;
        public Order(int id, int o, int desc, DateTime date, int amount, int price, string cab)
        {
            this.id = id;
            this.o = o;
            this.desc = desc;
            this.date = date;
            this.amount = amount;
            this.price = price;
            this.cab = cab;
        }
        public Order(int id, int o, int desc, int color, DateTime date, int amount, int price, string cab, string status, DateTime finish, DateTime delivered, int paid, bool full)
        {
            this.id = id;
            this.o = o;
            this.desc = desc;
            this.color = color;
            this.date = date;
            this.amount = amount;
            this.price = price;
            this.cab = cab;
            this.status = status;
            this.finish = finish;
            this.delivered = delivered;
            this.paid = paid;
            this.full = full;
        }
        public Order (int o, int desc, int color, DateTime date, int amount, int price, string cab, string status, DateTime finish)
        {
            this.o = o;
            this.desc = desc;
            this.color = color;
            this.date = date;
            this.amount = amount;
            this.price = price;
            this.cab = cab;
            this.status = status;
            this.finish = finish;
        }
        public Order(int o, int desc, int color, DateTime date, int amount, int price, string cab, string status, DateTime finish, int paid, bool full)
        {
            this.o = o;
            this.desc = desc;
            this.color = color;
            this.date = date;
            this.amount = amount;
            this.price = price;
            this.cab = cab;
            this.status = status;
            this.finish = finish;
            this.paid = paid;
            this.full = full;
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int O
        {
            get { return this.o; }
            set { this.o = value; }
        }
        public int Desc
        {
            get { return this.desc; }
            set { this.desc = value; }
        }
        public int Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public int Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Cab
        {
            get { return this.cab; }
            set { this.cab = value; }
        }
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }
        public DateTime Finish
        {
            get { return this.finish; }
            set { this.finish = value; }
        }
        public DateTime Delivered
        {
            get { return this.delivered; }
            set { this.delivered = value; }
        }
        public int Paid
        {
            get { return this.paid; }
            set { this.paid = value; }
        }
        public bool Full
        {
            get { return this.full; }
            set { this.full = value; }
        }
    }
}
