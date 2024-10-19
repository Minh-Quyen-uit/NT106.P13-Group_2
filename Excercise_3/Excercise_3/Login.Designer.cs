namespace Excercise_3
{
    partial class Login
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
            panel6 = new Panel();
            Exit_Btn = new Button();
            panel5 = new Panel();
            PasswordCheck = new CheckBox();
            Login_Btn = new Button();
            panel4 = new Panel();
            SignUp_Btn = new Button();
            label4 = new Label();
            panel3 = new Panel();
            PassWord = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            UserName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 414);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(Exit_Btn);
            panel6.Location = new Point(3, 317);
            panel6.Name = "panel6";
            panel6.Size = new Size(525, 52);
            panel6.TabIndex = 4;
            // 
            // Exit_Btn
            // 
            Exit_Btn.BackColor = Color.Red;
            Exit_Btn.ForeColor = SystemColors.ControlLightLight;
            Exit_Btn.Location = new Point(327, 8);
            Exit_Btn.Name = "Exit_Btn";
            Exit_Btn.Size = new Size(177, 37);
            Exit_Btn.TabIndex = 5;
            Exit_Btn.Text = "Thoát";
            Exit_Btn.UseVisualStyleBackColor = false;
            Exit_Btn.Click += Exit_Btn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(PasswordCheck);
            panel5.Controls.Add(Login_Btn);
            panel5.Location = new Point(3, 197);
            panel5.Name = "panel5";
            panel5.Size = new Size(528, 54);
            panel5.TabIndex = 3;
            // 
            // PasswordCheck
            // 
            PasswordCheck.AutoSize = true;
            PasswordCheck.Location = new Point(3, 9);
            PasswordCheck.Name = "PasswordCheck";
            PasswordCheck.Size = new Size(199, 30);
            PasswordCheck.TabIndex = 4;
            PasswordCheck.Text = "Hiện thị mật khẩu";
            PasswordCheck.UseVisualStyleBackColor = true;
            PasswordCheck.CheckedChanged += PasswordCheck_CheckedChanged;
            // 
            // Login_Btn
            // 
            Login_Btn.BackColor = SystemColors.ActiveCaption;
            Login_Btn.Location = new Point(327, 9);
            Login_Btn.Name = "Login_Btn";
            Login_Btn.Size = new Size(177, 37);
            Login_Btn.TabIndex = 3;
            Login_Btn.Text = "Đăng Nhập";
            Login_Btn.UseVisualStyleBackColor = false;
            Login_Btn.Click += Login_Btn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(SignUp_Btn);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 257);
            panel4.Name = "panel4";
            panel4.Size = new Size(525, 54);
            panel4.TabIndex = 2;
            // 
            // SignUp_Btn
            // 
            SignUp_Btn.BackColor = SystemColors.GradientActiveCaption;
            SignUp_Btn.Location = new Point(327, 8);
            SignUp_Btn.Name = "SignUp_Btn";
            SignUp_Btn.Size = new Size(177, 37);
            SignUp_Btn.TabIndex = 4;
            SignUp_Btn.Text = "Đăng Kí";
            SignUp_Btn.UseVisualStyleBackColor = false;
            SignUp_Btn.Click += SignUp_Btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 13);
            label4.Name = "label4";
            label4.Size = new Size(234, 26);
            label4.TabIndex = 0;
            label4.Text = "Bạn chưa có tài khoản ?";
            // 
            // panel3
            // 
            panel3.Controls.Add(PassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(525, 54);
            panel3.TabIndex = 1;
            // 
            // PassWord
            // 
            PassWord.Location = new Point(175, 9);
            PassWord.Name = "PassWord";
            PassWord.PasswordChar = '*';
            PassWord.Size = new Size(329, 34);
            PassWord.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(109, 26);
            label3.TabIndex = 0;
            label3.Text = "Mật Khẩu:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 14);
            label1.Name = "label1";
            label1.Size = new Size(172, 39);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập";
            // 
            // panel2
            // 
            panel2.Controls.Add(UserName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(525, 54);
            panel2.TabIndex = 0;
            // 
            // UserName
            // 
            UserName.Location = new Point(175, 9);
            UserName.Name = "UserName";
            UserName.Size = new Size(329, 34);
            UserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(166, 26);
            label2.TabIndex = 0;
            label2.Text = "Tên Đăng Nhập:";
            // 
            // Login
            // 
            AcceptButton = Login_Btn;
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 438);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
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
        private Panel panel5;
        private Button Login_Btn;
        private Panel panel4;
        private Button SignUp_Btn;
        private Label label4;
        private Panel panel3;
        private TextBox PassWord;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private TextBox UserName;
        private Label label2;
        private Panel panel6;
        private Button Exit_Btn;
        private CheckBox PasswordCheck;
    }
}