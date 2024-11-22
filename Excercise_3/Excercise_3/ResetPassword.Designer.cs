namespace Excercise_3
{
    partial class ResetPassword
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
            label1 = new Label();
            NewPassword_Tb = new TextBox();
            panel2 = new Panel();
            RENewPassword_Tb = new TextBox();
            label2 = new Label();
            Confirm_Btn = new Button();
            Exit_Btn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(NewPassword_Tb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 114);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 8);
            label1.Name = "label1";
            label1.Size = new Size(251, 34);
            label1.TabIndex = 0;
            label1.Text = "Nhập mật khẩu mới";
            // 
            // NewPassword_Tb
            // 
            NewPassword_Tb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewPassword_Tb.Location = new Point(0, 45);
            NewPassword_Tb.Name = "NewPassword_Tb";
            NewPassword_Tb.Size = new Size(507, 42);
            NewPassword_Tb.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(RENewPassword_Tb);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(2, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(512, 114);
            panel2.TabIndex = 2;
            // 
            // RENewPassword_Tb
            // 
            RENewPassword_Tb.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RENewPassword_Tb.Location = new Point(0, 45);
            RENewPassword_Tb.Name = "RENewPassword_Tb";
            RENewPassword_Tb.Size = new Size(507, 42);
            RENewPassword_Tb.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 8);
            label2.Name = "label2";
            label2.Size = new Size(251, 34);
            label2.TabIndex = 0;
            label2.Text = "Nhập mật khẩu mới";
            // 
            // Confirm_Btn
            // 
            Confirm_Btn.BackColor = Color.GreenYellow;
            Confirm_Btn.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Confirm_Btn.Location = new Point(2, 262);
            Confirm_Btn.Name = "Confirm_Btn";
            Confirm_Btn.Size = new Size(142, 43);
            Confirm_Btn.TabIndex = 5;
            Confirm_Btn.Text = "Confirm";
            Confirm_Btn.UseVisualStyleBackColor = false;
            Confirm_Btn.Click += Confirm_Btn_Click;
            // 
            // Exit_Btn
            // 
            Exit_Btn.BackColor = Color.Red;
            Exit_Btn.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit_Btn.Location = new Point(372, 262);
            Exit_Btn.Name = "Exit_Btn";
            Exit_Btn.Size = new Size(142, 43);
            Exit_Btn.TabIndex = 6;
            Exit_Btn.Text = "Thoát";
            Exit_Btn.UseVisualStyleBackColor = false;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 317);
            Controls.Add(Exit_Btn);
            Controls.Add(Confirm_Btn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ResetPassword";
            Text = "ResetPassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox NewPassword_Tb;
        private Label label1;
        private Panel panel2;
        private TextBox RENewPassword_Tb;
        private Label label2;
        private Button Confirm_Btn;
        private Button Exit_Btn;
    }
}