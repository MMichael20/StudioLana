using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Item
    {
        private int id;
        private string name;
        private int price;
        private int length;

        public Item(int id, string name, int price, int length)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.length = length;
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }
    }
}
