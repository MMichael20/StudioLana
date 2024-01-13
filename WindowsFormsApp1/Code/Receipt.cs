using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Receipt : Check
    {
        public Receipt(int user, string name, int price, int type)
        {
            this.User = user;
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }
    }
}
