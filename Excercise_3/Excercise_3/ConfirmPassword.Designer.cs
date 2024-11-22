namespace Excercise_3
{
    partial class ConfirmPassword
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
            Password_Tb = new TextBox();
            Confirm_Btn = new Button();
            Exit_Btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 34);
            label1.TabIndex = 2;
            label1.Text = "Nhập mật khẩu hiện tại";
            // 
            // Password_Tb
            // 
            Password_Tb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_Tb.Location = new Point(12, 46);
            Password_Tb.Name = "Password_Tb";
            Password_Tb.Size = new Size(433, 42);
            Password_Tb.TabIndex = 3;
            Password_Tb.UseSystemPasswordChar = true;
            // 
            // Confirm_Btn
            // 
            Confirm_Btn.BackColor = Color.GreenYellow;
            Confirm_Btn.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Confirm_Btn.Location = new Point(12, 94);
            Confirm_Btn.Name = "Confirm_Btn";
            Confirm_Btn.Size = new Size(142, 43);
            Confirm_Btn.TabIndex = 4;
            Confirm_Btn.Text = "Confirm";
            Confirm_Btn.UseVisualStyleBackColor = false;
            Confirm_Btn.Click += Confirm_Btn_Click;
            // 
            // Exit_Btn
            // 
            Exit_Btn.BackColor = Color.Red;
            Exit_Btn.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit_Btn.Location = new Point(303, 94);
            Exit_Btn.Name = "Exit_Btn";
            Exit_Btn.Size = new Size(142, 43);
            Exit_Btn.TabIndex = 5;
            Exit_Btn.Text = "Thoát";
            Exit_Btn.UseVisualStyleBackColor = false;
            Exit_Btn.Click += Exit_Btn_Click;
            // 
            // ConfirmPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 143);
            Controls.Add(Exit_Btn);
            Controls.Add(Confirm_Btn);
            Controls.Add(Password_Tb);
            Controls.Add(label1);
            Name = "ConfirmPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Password_Tb;
        private Button Confirm_Btn;
        private Button Exit_Btn;
    }
}