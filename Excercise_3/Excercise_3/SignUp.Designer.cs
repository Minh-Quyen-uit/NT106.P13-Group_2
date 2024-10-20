namespace Excercise_3
{
    partial class SignUp
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
            PasswordCheck = new CheckBox();
            panel8 = new Panel();
            Login_Btn = new Button();
            label8 = new Label();
            SignUp_Btn = new Button();
            panel7 = new Panel();
            BirthDay = new DateTimePicker();
            label7 = new Label();
            panel6 = new Panel();
            Email = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            FullName = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            PassWord_confirm = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            PassWord = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            UserName = new TextBox();
            label1 = new Label();
            Exit_Btn = new Button();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
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
            panel1.Controls.Add(Exit_Btn);
            panel1.Controls.Add(PasswordCheck);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(SignUp_Btn);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 614);
            panel1.TabIndex = 0;
            // 
            // PasswordCheck
            // 
            PasswordCheck.AutoSize = true;
            PasswordCheck.Location = new Point(312, 255);
            PasswordCheck.Name = "PasswordCheck";
            PasswordCheck.Size = new Size(199, 30);
            PasswordCheck.TabIndex = 9;
            PasswordCheck.Text = "Hiện thị mật khẩu";
            PasswordCheck.UseVisualStyleBackColor = true;
            PasswordCheck.CheckedChanged += PasswordCheck_CheckedChanged;
            // 
            // panel8
            // 
            panel8.Controls.Add(Login_Btn);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(0, 507);
            panel8.Name = "panel8";
            panel8.Size = new Size(511, 51);
            panel8.TabIndex = 8;
            // 
            // Login_Btn
            // 
            Login_Btn.BackColor = Color.Lime;
            Login_Btn.Location = new Point(368, 7);
            Login_Btn.Name = "Login_Btn";
            Login_Btn.Size = new Size(140, 35);
            Login_Btn.TabIndex = 8;
            Login_Btn.Text = "Đăng Nhập";
            Login_Btn.UseVisualStyleBackColor = false;
            Login_Btn.Click += Login_Btn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 11);
            label8.Name = "label8";
            label8.Size = new Size(181, 26);
            label8.TabIndex = 0;
            label8.Text = "Đã có tài khoản ? ";
            // 
            // SignUp_Btn
            // 
            SignUp_Btn.BackColor = Color.Cyan;
            SignUp_Btn.ForeColor = SystemColors.ActiveCaptionText;
            SignUp_Btn.Location = new Point(368, 466);
            SignUp_Btn.Name = "SignUp_Btn";
            SignUp_Btn.Size = new Size(143, 35);
            SignUp_Btn.TabIndex = 7;
            SignUp_Btn.Text = "Đăng Ký";
            SignUp_Btn.UseVisualStyleBackColor = false;
            SignUp_Btn.Click += SignUp_Btn_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(BirthDay);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(3, 409);
            panel7.Name = "panel7";
            panel7.Size = new Size(511, 51);
            panel7.TabIndex = 6;
            // 
            // BirthDay
            // 
            BirthDay.Format = DateTimePickerFormat.Short;
            BirthDay.Location = new Point(236, 5);
            BirthDay.Name = "BirthDay";
            BirthDay.RightToLeft = RightToLeft.No;
            BirthDay.Size = new Size(275, 34);
            BirthDay.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 11);
            label7.Name = "label7";
            label7.Size = new Size(111, 26);
            label7.TabIndex = 0;
            label7.Text = "Ngày sinh:";
            // 
            // panel6
            // 
            panel6.Controls.Add(Email);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(3, 352);
            panel6.Name = "panel6";
            panel6.Size = new Size(511, 51);
            panel6.TabIndex = 5;
            // 
            // Email
            // 
            Email.Location = new Point(236, 8);
            Email.Name = "Email";
            Email.Size = new Size(275, 34);
            Email.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 11);
            label6.Name = "label6";
            label6.Size = new Size(71, 26);
            label6.TabIndex = 0;
            label6.Text = "Email:";
            // 
            // panel5
            // 
            panel5.Controls.Add(FullName);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(3, 295);
            panel5.Name = "panel5";
            panel5.Size = new Size(511, 51);
            panel5.TabIndex = 4;
            // 
            // FullName
            // 
            FullName.Location = new Point(236, 11);
            FullName.Name = "FullName";
            FullName.Size = new Size(275, 34);
            FullName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 11);
            label5.Name = "label5";
            label5.Size = new Size(107, 26);
            label5.TabIndex = 0;
            label5.Text = "Họ và tên:";
            // 
            // panel4
            // 
            panel4.Controls.Add(PassWord_confirm);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 196);
            panel4.Name = "panel4";
            panel4.Size = new Size(511, 51);
            panel4.TabIndex = 3;
            // 
            // PassWord_confirm
            // 
            PassWord_confirm.Location = new Point(233, 8);
            PassWord_confirm.Name = "PassWord_confirm";
            PassWord_confirm.PasswordChar = '*';
            PassWord_confirm.Size = new Size(275, 34);
            PassWord_confirm.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(198, 26);
            label4.TabIndex = 0;
            label4.Text = "Xác nhận mật khẩu:";
            // 
            // panel3
            // 
            panel3.Controls.Add(PassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(511, 51);
            panel3.TabIndex = 2;
            // 
            // PassWord
            // 
            PassWord.Location = new Point(233, 8);
            PassWord.Name = "PassWord";
            PassWord.PasswordChar = '*';
            PassWord.Size = new Size(275, 34);
            PassWord.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(105, 26);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(207, 26);
            label2.Name = "label2";
            label2.Size = new Size(141, 39);
            label2.TabIndex = 1;
            label2.Text = "Đăng Ký";
            // 
            // panel2
            // 
            panel2.Controls.Add(UserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(511, 51);
            panel2.TabIndex = 0;
            // 
            // UserName
            // 
            UserName.Location = new Point(233, 8);
            UserName.Name = "UserName";
            UserName.Size = new Size(275, 34);
            UserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(163, 26);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập: ";
            // 
            // Exit_Btn
            // 
            Exit_Btn.BackColor = Color.Red;
            Exit_Btn.ForeColor = SystemColors.ControlLightLight;
            Exit_Btn.Location = new Point(368, 564);
            Exit_Btn.Name = "Exit_Btn";
            Exit_Btn.Size = new Size(140, 37);
            Exit_Btn.TabIndex = 10;
            Exit_Btn.Text = "Thoát";
            Exit_Btn.UseVisualStyleBackColor = false;
            Exit_Btn.Click += Exit_Btn_Click;
            // 
            // SignUp
            // 
            AcceptButton = SignUp_Btn;
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 625);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
        private Label label2;
        private Panel panel2;
        private TextBox UserName;
        private Label label1;
        private Panel panel7;
        private Label label7;
        private Panel panel6;
        private TextBox Email;
        private Label label6;
        private Panel panel5;
        private TextBox FullName;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private Panel panel3;
        private TextBox PassWord;
        private Label label3;
        private Panel panel8;
        private Label label8;
        private Button SignUp_Btn;
        private Button Login_Btn;
        private DateTimePicker BirthDay;
        private TextBox PassWord_confirm;
        private CheckBox PasswordCheck;
        private Button Exit_Btn;
    }
}