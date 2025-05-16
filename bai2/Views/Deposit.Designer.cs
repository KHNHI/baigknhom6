namespace BAI2GIUAKY.Views
{
    partial class Deposit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            btn_guitien = new Button();
            label2 = new Label();
            lbl_khonghople = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 99);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập số tiền cần gửi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(263, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 1;
            // 
            // btn_guitien
            // 
            btn_guitien.BackColor = SystemColors.ActiveCaption;
            btn_guitien.Location = new Point(314, 172);
            btn_guitien.Name = "btn_guitien";
            btn_guitien.Size = new Size(99, 44);
            btn_guitien.TabIndex = 2;
            btn_guitien.Text = "GỬI TIỀN";
            btn_guitien.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(296, 29);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 3;
            label2.Text = "DEPOSIT";
            // 
            // lbl_khonghople
            // 
            lbl_khonghople.AutoSize = true;
            lbl_khonghople.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_khonghople.ForeColor = Color.Red;
            lbl_khonghople.Location = new Point(263, 136);
            lbl_khonghople.Name = "lbl_khonghople";
            lbl_khonghople.Size = new Size(146, 20);
            lbl_khonghople.TabIndex = 4;
            lbl_khonghople.Text = "Số tiền không hợp lệ";
            lbl_khonghople.Visible = false;
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 288);
            Controls.Add(lbl_khonghople);
            Controls.Add(label2);
            Controls.Add(btn_guitien);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Deposit";
            Text = "Deposit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btn_guitien;
        private Label label2;
        private Label lbl_khonghople;
    }
}