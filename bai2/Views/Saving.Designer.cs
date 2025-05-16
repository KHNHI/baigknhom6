namespace BAI2GIUAKY.Views
{
    partial class Saving
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_back = new Button();
            txt_stk = new TextBox();
            txt_hoten = new TextBox();
            txt_diachi = new TextBox();
            txt_sdt = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 145);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Số tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 191);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 243);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 298);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(248, 394);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(114, 47);
            btn_back.TabIndex = 4;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // txt_stk
            // 
            txt_stk.Location = new Point(229, 145);
            txt_stk.Name = "txt_stk";
            txt_stk.Size = new Size(150, 23);
            txt_stk.TabIndex = 5;
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(229, 188);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(150, 23);
            txt_hoten.TabIndex = 6;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(229, 243);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(150, 23);
            txt_diachi.TabIndex = 7;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(229, 295);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(150, 23);
            txt_sdt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(248, 46);
            label5.Name = "label5";
            label5.Size = new Size(123, 40);
            label5.TabIndex = 9;
            label5.Text = "SAVING";
            // 
            // Saving
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 532);
            Controls.Add(label5);
            Controls.Add(txt_sdt);
            Controls.Add(txt_diachi);
            Controls.Add(txt_hoten);
            Controls.Add(txt_stk);
            Controls.Add(btn_back);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Saving";
            Text = "Saving";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_back;
        private TextBox txt_stk;
        private TextBox txt_hoten;
        private TextBox txt_diachi;
        private TextBox txt_sdt;
        private Label label5;
    }
}