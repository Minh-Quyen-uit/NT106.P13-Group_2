namespace Excercise_3
{
    partial class Client_Server
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
            Client_Btn = new Button();
            Server_Btn = new Button();
            SuspendLayout();
            // 
            // Client_Btn
            // 
            Client_Btn.Location = new Point(63, 63);
            Client_Btn.Name = "Client_Btn";
            Client_Btn.Size = new Size(94, 29);
            Client_Btn.TabIndex = 0;
            Client_Btn.Text = "Client";
            Client_Btn.UseVisualStyleBackColor = true;
            Client_Btn.Click += Client_Btn_Click;
            // 
            // Server_Btn
            // 
            Server_Btn.Location = new Point(340, 63);
            Server_Btn.Name = "Server_Btn";
            Server_Btn.Size = new Size(94, 29);
            Server_Btn.TabIndex = 1;
            Server_Btn.Text = "Server";
            Server_Btn.UseVisualStyleBackColor = true;
            Server_Btn.Click += Server_Btn_Click;
            // 
            // Client_Server
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 146);
            Controls.Add(Server_Btn);
            Controls.Add(Client_Btn);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Client_Server";
            Text = "Client_Server";
            ResumeLayout(false);
        }

        #endregion

        private Button Client_Btn;
        private Button Server_Btn;
    }
}