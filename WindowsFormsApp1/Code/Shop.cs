using System;


namespace WindowsFormsApp1
{
    class Shop
    {
        private int id;
        private string name;
        private string note;
        private int amount;
        private DateTime date;
        private bool bought;

        public Shop(int id, string name, string note, int amount, DateTime date, bool bought)
        {
            this.id = id;
            this.name = name;
            this.note = note;
            this.amount = amount;
            this.date = date;
            this.bought = bought;
        }
        public Shop(string name, string note, int amount, DateTime date, bool bought)
        {
            this.name = name;
            this.note = note;
            this.amount = amount;
            this.date = date;
            this.bought = bought;
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

        public string Note
        {
            get { return this.note; }
            set { this.note = value; }
        }

        public int Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public bool Bought
        {
            get { return this.bought; }
            set { this.bought = value; }
        }
    }
}
