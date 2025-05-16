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
    public partial class Saving : Form
    {
        public Saving()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Dangnhap mainform = new Form_Dangnhap();
            mainform.ShowDialog();
        }
    }
}
