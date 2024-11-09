namespace Excercise_3
{
    partial class SearchScreen
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
            components = new System.ComponentModel.Container();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvBooks = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Authors = new DataGridViewTextBoxColumn();
            PublishedDate = new DataGridViewTextBoxColumn();
            Detail = new DataGridViewButtonColumn();
            progressBar = new ProgressBar();
            btnCreateBookshelf = new Button();
            txtBookshelfTitle = new TextBox();
            panel1 = new Panel();
            ShowBookShelfs = new Button();
            dvgBookshelf = new DataGridView();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            MenuTool = new ToolStripMenuItem();
            PersonInfo = new ToolStripMenuItem();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgBookshelf).BeginInit();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DeepSkyBlue;
            btnSearch.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(850, 7);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(237, 34);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(4, 7);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(840, 34);
            txtSearch.TabIndex = 1;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { Title, Authors, PublishedDate, Detail });
            dgvBooks.Location = new Point(4, 88);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(840, 459);
            dgvBooks.TabIndex = 2;
            // 
            // Title
            // 
            Title.HeaderText = "Tiêu Đề";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 125;
            // 
            // Authors
            // 
            Authors.HeaderText = "Tác giả";
            Authors.MinimumWidth = 6;
            Authors.Name = "Authors";
            Authors.Width = 125;
            // 
            // PublishedDate
            // 
            PublishedDate.HeaderText = "Ngày xuất bản";
            PublishedDate.MinimumWidth = 6;
            PublishedDate.Name = "PublishedDate";
            PublishedDate.Width = 125;
            // 
            // Detail
            // 
            Detail.HeaderText = "Chi tiết";
            Detail.MinimumWidth = 6;
            Detail.Name = "Detail";
            Detail.Width = 125;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(4, 47);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(546, 35);
            progressBar.TabIndex = 3;
            // 
            // btnCreateBookshelf
            // 
            btnCreateBookshelf.BackColor = Color.Fuchsia;
            btnCreateBookshelf.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateBookshelf.ForeColor = SystemColors.ButtonFace;
            btnCreateBookshelf.Location = new Point(850, 47);
            btnCreateBookshelf.Name = "btnCreateBookshelf";
            btnCreateBookshelf.Size = new Size(237, 35);
            btnCreateBookshelf.TabIndex = 4;
            btnCreateBookshelf.Text = "Tạo kệ sách";
            btnCreateBookshelf.UseVisualStyleBackColor = false;
            btnCreateBookshelf.Click += btnCreateBookshelf_Click;
            // 
            // txtBookshelfTitle
            // 
            txtBookshelfTitle.Location = new Point(556, 49);
            txtBookshelfTitle.Name = "txtBookshelfTitle";
            txtBookshelfTitle.Size = new Size(288, 34);
            txtBookshelfTitle.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(ShowBookShelfs);
            panel1.Controls.Add(dvgBookshelf);
            panel1.Controls.Add(txtBookshelfTitle);
            panel1.Controls.Add(btnCreateBookshelf);
            panel1.Controls.Add(progressBar);
            panel1.Controls.Add(dgvBooks);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(12, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1091, 550);
            panel1.TabIndex = 6;
            // 
            // ShowBookShelfs
            // 
            ShowBookShelfs.BackColor = Color.BlueViolet;
            ShowBookShelfs.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowBookShelfs.ForeColor = SystemColors.ButtonHighlight;
            ShowBookShelfs.Location = new Point(850, 86);
            ShowBookShelfs.Name = "ShowBookShelfs";
            ShowBookShelfs.Size = new Size(237, 34);
            ShowBookShelfs.TabIndex = 7;
            ShowBookShelfs.Text = "Hiện thị kệ sách";
            ShowBookShelfs.UseVisualStyleBackColor = false;
            ShowBookShelfs.Click += ShowBookShelfs_Click;
            // 
            // dvgBookshelf
            // 
            dvgBookshelf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgBookshelf.Location = new Point(850, 124);
            dvgBookshelf.Name = "dvgBookshelf";
            dvgBookshelf.RowHeadersWidth = 51;
            dvgBookshelf.Size = new Size(237, 423);
            dvgBookshelf.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1091, 46);
            panel2.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Cyan;
            menuStrip1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuTool });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1091, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuTool
            // 
            MenuTool.DropDownItems.AddRange(new ToolStripItem[] { PersonInfo });
            MenuTool.Name = "MenuTool";
            MenuTool.Size = new Size(86, 29);
            MenuTool.Text = "Menu";
            // 
            // PersonInfo
            // 
            PersonInfo.Name = "PersonInfo";
            PersonInfo.Size = new Size(281, 30);
            PersonInfo.Text = "Thông tin cá nhân";
            PersonInfo.Click += PersonInfo_Click;
            // 
            // SearchScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1115, 626);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "SearchScreen";
            Text = "SearchScreen";
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgBookshelf).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvBooks;
        private ProgressBar progressBar;
        private Button btnCreateBookshelf;
        private TextBox txtBookshelfTitle;
        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuTool;
        private ToolStripMenuItem PersonInfo;
        private DataGridView dvgBookshelf;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Authors;
        private DataGridViewTextBoxColumn PublishedDate;
        private DataGridViewButtonColumn Detail;
        private System.Windows.Forms.Timer timer;
        private Button ShowBookShelfs;
    }
}