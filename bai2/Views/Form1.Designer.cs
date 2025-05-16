namespace BAI2GIUAKY
{
    partial class Form_Dangnhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_dangnhap = new Label();
            lbl_ten = new Label();
            label2 = new Label();
            txt_ten = new TextBox();
            txt_matkhau = new TextBox();
            label1 = new Label();
            lbl_saipassword = new Label();
            btn_dangnhap = new Button();
            SuspendLayout();
            // 
            // lbl_dangnhap
            // 
            lbl_dangnhap.AutoSize = true;
            lbl_dangnhap.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_dangnhap.ForeColor = SystemColors.ActiveCaptionText;
            lbl_dangnhap.Location = new Point(256, 47);
            lbl_dangnhap.Name = "lbl_dangnhap";
            lbl_dangnhap.Size = new Size(236, 47);
            lbl_dangnhap.TabIndex = 0;
            lbl_dangnhap.Text = "ĐĂNG NHẬP";
            lbl_dangnhap.UseWaitCursor = true;
            // 
            // lbl_ten
            // 
            lbl_ten.AutoSize = true;
            lbl_ten.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ten.Location = new Point(143, 160);
            lbl_ten.Name = "lbl_ten";
            lbl_ten.Size = new Size(37, 21);
            lbl_ten.TabIndex = 1;
            lbl_ten.Text = "Tên";
            lbl_ten.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(143, 232);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            label2.UseWaitCursor = true;
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(286, 158);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(187, 23);
            txt_ten.TabIndex = 3;
            txt_ten.UseWaitCursor = true;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(286, 234);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(187, 23);
            txt_matkhau.TabIndex = 4;
            txt_matkhau.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(286, 193);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 5;
            label1.Text = "Sai username";
            label1.UseWaitCursor = true;
            label1.Visible = false;
            // 
            // lbl_saipassword
            // 
            lbl_saipassword.AutoSize = true;
            lbl_saipassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_saipassword.ForeColor = Color.IndianRed;
            lbl_saipassword.Location = new Point(286, 277);
            lbl_saipassword.Name = "lbl_saipassword";
            lbl_saipassword.Size = new Size(107, 21);
            lbl_saipassword.TabIndex = 6;
            lbl_saipassword.Text = "sai mật khẩu";
            lbl_saipassword.UseWaitCursor = true;
            lbl_saipassword.Visible = false;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dangnhap.Location = new Point(276, 347);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(177, 43);
            btn_dangnhap.TabIndex = 7;
            btn_dangnhap.Text = "Đăng nhập";
            btn_dangnhap.UseVisualStyleBackColor = true;
            btn_dangnhap.UseWaitCursor = true;
            // 
            // Form_Dangnhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 455);
            Controls.Add(btn_dangnhap);
            Controls.Add(lbl_saipassword);
            Controls.Add(label1);
            Controls.Add(txt_matkhau);
            Controls.Add(txt_ten);
            Controls.Add(label2);
            Controls.Add(lbl_ten);
            Controls.Add(lbl_dangnhap);
            Name = "Form_Dangnhap";
            Text = "Đăng nhập";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_dangnhap;
        private Label lbl_ten;
        private Label label2;
        private TextBox txt_ten;
        private TextBox txt_matkhau;
        private Label label1;
        private Label lbl_saipassword;
        private Button btn_dangnhap;
    }
}
