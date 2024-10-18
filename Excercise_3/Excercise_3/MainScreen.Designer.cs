namespace Excercise_3
{
    partial class MainScreen
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
            panel1 = new Panel();
            panel7 = new Panel();
            LogOut_Btn = new Button();
            Exit_Btn = new Button();
            panel6 = new Panel();
            BirthDay = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            Email = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            FullName = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            PassWord = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            UserName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 445);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(LogOut_Btn);
            panel7.Controls.Add(Exit_Btn);
            panel7.Location = new Point(6, 380);
            panel7.Name = "panel7";
            panel7.Size = new Size(441, 52);
            panel7.TabIndex = 7;
            // 
            // LogOut_Btn
            // 
            LogOut_Btn.BackColor = Color.Teal;
            LogOut_Btn.ForeColor = SystemColors.ButtonFace;
            LogOut_Btn.Location = new Point(261, 8);
            LogOut_Btn.Name = "LogOut_Btn";
            LogOut_Btn.Size = new Size(177, 37);
            LogOut_Btn.TabIndex = 6;
            LogOut_Btn.Text = "Đăng Xuất";
            LogOut_Btn.UseVisualStyleBackColor = false;
            LogOut_Btn.Click += LogOut_Btn_Click;
            // 
            // Exit_Btn
            // 
            Exit_Btn.BackColor = Color.Red;
            Exit_Btn.ForeColor = SystemColors.ControlLightLight;
            Exit_Btn.Location = new Point(3, 8);
            Exit_Btn.Name = "Exit_Btn";
            Exit_Btn.Size = new Size(177, 37);
            Exit_Btn.TabIndex = 5;
            Exit_Btn.Text = "Thoát";
            Exit_Btn.UseVisualStyleBackColor = false;
            Exit_Btn.Click += Exit_Btn_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(BirthDay);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(6, 320);
            panel6.Name = "panel6";
            panel6.Size = new Size(441, 54);
            panel6.TabIndex = 6;
            // 
            // BirthDay
            // 
            BirthDay.Location = new Point(175, 9);
            BirthDay.Name = "BirthDay";
            BirthDay.ReadOnly = true;
            BirthDay.Size = new Size(263, 30);
            BirthDay.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 12);
            label6.Name = "label6";
            label6.Size = new Size(94, 22);
            label6.TabIndex = 0;
            label6.Text = "Ngày sinh:";
            // 
            // panel5
            // 
            panel5.Controls.Add(Email);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(6, 260);
            panel5.Name = "panel5";
            panel5.Size = new Size(441, 54);
            panel5.TabIndex = 5;
            // 
            // Email
            // 
            Email.Location = new Point(175, 9);
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Size = new Size(263, 30);
            Email.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 12);
            label5.Name = "label5";
            label5.Size = new Size(68, 22);
            label5.TabIndex = 0;
            label5.Text = "Email: ";
            // 
            // panel4
            // 
            panel4.Controls.Add(FullName);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(6, 200);
            panel4.Name = "panel4";
            panel4.Size = new Size(441, 54);
            panel4.TabIndex = 4;
            // 
            // FullName
            // 
            FullName.Location = new Point(175, 9);
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Size = new Size(263, 30);
            FullName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 12);
            label4.Name = "label4";
            label4.Size = new Size(97, 22);
            label4.TabIndex = 0;
            label4.Text = "Họ và tên: ";
            // 
            // panel3
            // 
            panel3.Controls.Add(PassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(6, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(441, 54);
            panel3.TabIndex = 3;
            // 
            // PassWord
            // 
            PassWord.Location = new Point(175, 9);
            PassWord.Name = "PassWord";
            PassWord.ReadOnly = true;
            PassWord.Size = new Size(263, 30);
            PassWord.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(93, 22);
            label3.TabIndex = 0;
            label3.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 16);
            label1.Name = "label1";
            label1.Size = new Size(279, 39);
            label1.TabIndex = 2;
            label1.Text = "Thông tin tài khoản";
            // 
            // panel2
            // 
            panel2.Controls.Add(UserName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(6, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 54);
            panel2.TabIndex = 1;
            // 
            // UserName
            // 
            UserName.Location = new Point(175, 9);
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Size = new Size(263, 30);
            UserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(139, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên Đăng Nhập:";
            // 
            // MainScreen
            // 
            AcceptButton = LogOut_Btn;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(471, 466);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Màn hình chính";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox UserName;
        private Label label2;
        private Panel panel6;
        private TextBox BirthDay;
        private Label label6;
        private Panel panel5;
        private TextBox Email;
        private Label label5;
        private Panel panel4;
        private TextBox FullName;
        private Label label4;
        private Panel panel3;
        private TextBox PassWord;
        private Label label3;
        private Label label1;
        private Panel panel7;
        private Button Exit_Btn;
        private Button LogOut_Btn;
    }
}