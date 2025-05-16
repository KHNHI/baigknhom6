using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI2GIUAKY.Views
{
    public partial class Checkin : Form
    {
        public Checkin()
        {
            InitializeComponent();
        }

       

        private void btn_Deposit_Click(object sender, EventArgs e)
        {

            Deposit depositForm = new Deposit();
            depositForm.ShowDialog();
        }


        private void btn_display_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
        }
    }
}
