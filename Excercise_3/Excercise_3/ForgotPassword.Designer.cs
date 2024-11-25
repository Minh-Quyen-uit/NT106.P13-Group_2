namespace Excercise_3
{
    partial class ForgotPassword
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
            Email_Tb = new TextBox();
            Send_Btn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Email_Tb
            // 
            Email_Tb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email_Tb.Location = new Point(12, 38);
            Email_Tb.Name = "Email_Tb";
            Email_Tb.Size = new Size(377, 38);
            Email_Tb.TabIndex = 0;
            // 
            // Send_Btn
            // 
            Send_Btn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Send_Btn.Location = new Point(413, 44);
            Send_Btn.Name = "Send_Btn";
            Send_Btn.Size = new Size(123, 31);
            Send_Btn.TabIndex = 1;
            Send_Btn.Text = "Send";
            Send_Btn.UseVisualStyleBackColor = true;
            Send_Btn.Click += Send_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 26);
            label1.TabIndex = 2;
            label1.Text = "Nhập email khôi phục";
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 123);
            Controls.Add(label1);
            Controls.Add(Send_Btn);
            Controls.Add(Email_Tb);
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Email_Tb;
        private Button Send_Btn;
        private Label label1;
    }
}