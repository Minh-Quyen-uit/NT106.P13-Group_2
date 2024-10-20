﻿namespace Excercise_3
{
    partial class Server
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
            ServerScreen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SendMess = new TextBox();
            Exit_Btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 38);
            label1.TabIndex = 0;
            label1.Text = "Server";
            // 
            // ServerScreen
            // 
            ServerScreen.BackColor = Color.White;
            ServerScreen.ForeColor = Color.FromArgb(0, 0, 64);
            ServerScreen.Location = new Point(36, 99);
            ServerScreen.Multiline = true;
            ServerScreen.Name = "ServerScreen";
            ServerScreen.ReadOnly = true;
            ServerScreen.ScrollBars = ScrollBars.Vertical;
            ServerScreen.Size = new Size(585, 171);
            ServerScreen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 66);
            label2.Name = "label2";
            label2.Size = new Size(364, 26);
            label2.TabIndex = 3;
            label2.Text = "Hiện thị thông tin client gửi tới server:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 296);
            label3.Name = "label3";
            label3.Size = new Size(364, 26);
            label3.TabIndex = 4;
            label3.Text = "Hiện thị thông tin server gửi tới client:";
            // 
            // SendMess
            // 
            SendMess.BackColor = Color.White;
            SendMess.ForeColor = Color.FromArgb(0, 0, 64);
            SendMess.Location = new Point(36, 329);
            SendMess.Multiline = true;
            SendMess.Name = "SendMess";
            SendMess.ReadOnly = true;
            SendMess.ScrollBars = ScrollBars.Vertical;
            SendMess.Size = new Size(585, 171);
            SendMess.TabIndex = 5;
            // 
            // Exit_Btn
            // 
            Exit_Btn.BackColor = Color.Red;
            Exit_Btn.ForeColor = SystemColors.ControlLightLight;
            Exit_Btn.Location = new Point(444, 516);
            Exit_Btn.Name = "Exit_Btn";
            Exit_Btn.Size = new Size(177, 37);
            Exit_Btn.TabIndex = 6;
            Exit_Btn.Text = "Thoát";
            Exit_Btn.UseVisualStyleBackColor = false;
            Exit_Btn.Click += Exit_Btn_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(655, 565);
            Controls.Add(Exit_Btn);
            Controls.Add(SendMess);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ServerScreen);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Server";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ServerScreen;
        private Label label2;
        private Label label3;
        private TextBox SendMess;
        private Button Exit_Btn;
    }
}