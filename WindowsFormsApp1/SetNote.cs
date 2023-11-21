using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SetNote : Form
    {
        public SetNote()
        {
            InitializeComponent();
        }

        private void SetNote_Load(object sender, EventArgs e)
        {
            this.ActiveControl = NoteBox;
        }

        private void SumbitB_Click(object sender, EventArgs e)
        {
            if(NoteBox.Text == "")
            {
                Msg.Text = "רשום הערה!";
            }
            else
            {
                Choose.note = NoteBox.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            
        }
    }
}
