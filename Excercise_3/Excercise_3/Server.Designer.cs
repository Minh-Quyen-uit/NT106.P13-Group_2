namespace Excercise_3
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
            DgvAccounts = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvAccounts).BeginInit();
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
            // DgvAccounts
            // 
            DgvAccounts.BackgroundColor = SystemColors.ButtonHighlight;
            DgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvAccounts.Location = new Point(36, 326);
            DgvAccounts.Name = "DgvAccounts";
            DgvAccounts.RowHeadersWidth = 51;
            DgvAccounts.Size = new Size(585, 188);
            DgvAccounts.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 71);
            label2.Name = "label2";
            label2.Size = new Size(291, 26);
            label2.TabIndex = 3;
            label2.Text = "Hiện thị thông tin được gửi tới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 300);
            label3.Name = "label3";
            label3.Size = new Size(491, 26);
            label3.TabIndex = 4;
            label3.Text = "Thông tin tài khoản cần xác minh / thêm vào CSDL";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(655, 564);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DgvAccounts);
            Controls.Add(ServerScreen);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Server";
            Text = "Server";
            ((System.ComponentModel.ISupportInitialize)DgvAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ServerScreen;
        private DataGridView DgvAccounts;
        private Label label2;
        private Label label3;
    }
}