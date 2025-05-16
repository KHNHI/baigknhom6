namespace BAI2GIUAKY.Views
{
    partial class Checkin
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
            listView1 = new ListView();
            btn_display = new Button();
            btn_Deposit = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(634, 186);
            listView1.Name = "listView1";
            listView1.Size = new Size(486, 303);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_display
            // 
            btn_display.Location = new Point(796, 77);
            btn_display.Name = "btn_display";
            btn_display.Size = new Size(153, 52);
            btn_display.TabIndex = 4;
            btn_display.Text = "Display transaction";
            btn_display.UseVisualStyleBackColor = true;
            btn_display.Click += btn_display_Click;
            // 
            // btn_Deposit
            // 
            btn_Deposit.Location = new Point(305, 77);
            btn_Deposit.Name = "btn_Deposit";
            btn_Deposit.Size = new Size(153, 52);
            btn_Deposit.TabIndex = 3;
            btn_Deposit.Text = "Deposit";
            btn_Deposit.UseVisualStyleBackColor = true;
            btn_Deposit.Click += btn_Deposit_Click;
            // 
            // Checkin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 567);
            Controls.Add(listView1);
            Controls.Add(btn_display);
            Controls.Add(btn_Deposit);
            Name = "Checkin";
            Text = "Checkin";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button btn_display;
        private Button btn_Deposit;
    }
}