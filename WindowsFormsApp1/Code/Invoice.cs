using System;

namespace WindowsFormsApp1
{
    class Invoice : Check
    {
        public Invoice(int user, string name, int price, DateTime date)
        {
            this.User = user;
            this.Name = name;
            this.Price = price;
            this.Date = date;
        }
        public Invoice(int user, string name, int price)
        {
            this.User = user;
            this.Name = name;
            this.Price = price;
        }
    }
}
