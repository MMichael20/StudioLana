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
        private int cab;
        private string status;
        private DateTime finish;
        public Order(int id, int o, int desc, DateTime date, int amount, int price, int cab)
        {
            this.id = id;
            this.o = o;
            this.desc = desc;
            this.date = date;
            this.amount = amount;
            this.price = price;
            this.cab = cab;
        }
        public Order(int id, int o, int desc, int color, DateTime date, int amount, int price, int cab, string status, DateTime finish)
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
        }
        public Order (int o, int desc, int color, DateTime date, int amount, int price, int cab, string status, DateTime finish)
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
        public int Cab
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
    }
}
