using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Color
    {
        private int id;
        private string cname;

        public Color(int id , string cname)
        {
            this.id = id;
            this.cname = cname;
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Cname
        {
            get { return this.cname; }
            set { this.cname = value; }
        }
    }
}
