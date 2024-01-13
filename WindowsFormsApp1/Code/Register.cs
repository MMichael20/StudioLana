using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Register
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Start { get; set; }
        public int Cash { get; set; }
        public int Bit { get; set; }
        public int Paybox { get; set; }
        public int Checks { get; set; }
        public int Credit { get; set; }
        public int Other { get; set; }
        public Register(int id, DateTime date, int start, int cash, int bit, int paybox, int checks, int credit, int other)
        {
            Id = id;
            Date = date;
            Start = start;
            Cash = cash;
            Bit = bit;
            Paybox = paybox;
            Checks = checks;
            Credit = credit;
            Other = other;
        }
        public Register()
        {

        }
        public int Sum()
        {
            return Start + Cash + Bit + Paybox + Checks + Credit + Other;
        }
    }
}
