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
            ServerScreen.BackColor = Color.Silver;
            ServerScreen.ForeColor = Color.FromArgb(0, 0, 64);
            ServerScreen.Location = new Point(36, 70);
            ServerScreen.Multiline = true;
            ServerScreen.Name = "ServerScreen";
            ServerScreen.ReadOnly = true;
            ServerScreen.Size = new Size(552, 250);
            ServerScreen.TabIndex = 1;
            // 
            // DgvAccounts
            // 
            DgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvAccounts.Location = new Point(36, 326);
            DgvAccounts.Name = "DgvAccounts";
            DgvAccounts.RowHeadersWidth = 51;
            DgvAccounts.Size = new Size(715, 188);
            DgvAccounts.TabIndex = 2;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(794, 529);
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
    }
}