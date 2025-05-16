using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_Nhom_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtMaSo.Text);
            item.SubItems.Add(txtHoTen.Text);
            item.SubItems.Add(txtNgaySinh.Text);
            item.SubItems.Add(txtEmail.Text);
            lvNhanVien.Items.Add(item);

            txtMaSo.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Clear();
            txtEmail.Clear();
            txtMaSo.Focus();


            
            btnAdd.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            txtMaSo.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Clear();
            txtEmail.Clear();
            txtMaSo.Focus();


            lvNhanVien.Items.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.Items.Count == 0)
            {
                MessageBox.Show("Chưa có nhân viên nào để lưu!");
                return;
            }

            if (lvNhanVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên trước khi lưu!");
                return;
            }


            ListViewItem selectedItem = lvNhanVien.SelectedItems[0];

            selectedItem.Text = txtMaSo.Text;
            selectedItem.SubItems[1].Text = txtHoTen.Text;
            selectedItem.SubItems[2].Text = txtNgaySinh.Text;
            selectedItem.SubItems[3].Text = txtEmail.Text;

            SaveFile();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvNhanVien.SelectedItems[0];
                txtMaSo.Text = item.Text;
                txtHoTen.Text = item.SubItems[1].Text;
                txtNgaySinh.Text = item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
        }


        public void ReadFile()
        {
            string FilePath = "dulieu.txt";
            if (System.IO.File.Exists(FilePath))
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(FilePath))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        ListViewItem item = new ListViewItem(data[0]);

                        if (data.Length > 3)
                        {
                            ListViewItem items = new ListViewItem(data[0]);
                            item.SubItems.Add(data[1]);
                            item.SubItems.Add(data[2]);
                            item.SubItems.Add(data[3]);
                            lvNhanVien.Items.Add(item);
                        }

                    }
                }
            }
        }

        public void SaveFile()
        {
            string FilePath = "dulieu.txt";


            //Lưu dữ liệu vào file dulieu.txt
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(FilePath))
            {
                foreach (ListViewItem item in lvNhanVien.Items)
                {
                    string line = item.Text + "," + item.SubItems[1].Text + "," + item.SubItems[2].Text + "," + item.SubItems[3].Text;
                    file.WriteLine(line);
                }
            }

        }

        private void lvNhanVien_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void lvNhanVien_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvNhanVien.SelectedItems[0];
                txtMaSo.Text = item.Text;
                txtHoTen.Text = item.SubItems[1].Text;
                txtNgaySinh.Text = item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;
            }
        }

      
    }
}
