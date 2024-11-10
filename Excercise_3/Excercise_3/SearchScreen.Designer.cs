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
            isbn = new DataGridViewTextBoxColumn();
            selecBook = new DataGridViewButtonColumn();
            progressBar = new ProgressBar();
            btnCreateBookshelf = new Button();
            txtBookshelfTitle = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            dgvShowBookShelfs = new DataGridView();
            dgvBookshelf = new DataGridView();
            BookShelfPersonal = new DataGridViewTextBoxColumn();
            SelecBookshelf = new DataGridViewCheckBoxColumn();
            DeleteBookShelf = new DataGridViewButtonColumn();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            MenuTool = new ToolStripMenuItem();
            PersonInfo = new ToolStripMenuItem();
            timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowBookShelfs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookshelf).BeginInit();
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
            btnSearch.Size = new Size(387, 34);
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
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { Title, Authors, PublishedDate, isbn, selecBook });
            dgvBooks.Location = new Point(4, 88);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(840, 189);
            dgvBooks.TabIndex = 2;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
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
            // isbn
            // 
            isbn.HeaderText = "Mã sách";
            isbn.MinimumWidth = 6;
            isbn.Name = "isbn";
            isbn.Width = 125;
            // 
            // selecBook
            // 
            selecBook.HeaderText = "Thêm sách vào kệ";
            selecBook.MinimumWidth = 6;
            selecBook.Name = "selecBook";
            selecBook.Width = 125;
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
            btnCreateBookshelf.Size = new Size(387, 35);
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dgvBookshelf);
            panel1.Controls.Add(txtBookshelfTitle);
            panel1.Controls.Add(btnCreateBookshelf);
            panel1.Controls.Add(progressBar);
            panel1.Controls.Add(dgvBooks);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1240, 550);
            panel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvShowBookShelfs);
            panel3.Location = new Point(0, 316);
            panel3.Name = "panel3";
            panel3.Size = new Size(1240, 231);
            panel3.TabIndex = 7;
            // 
            // dgvShowBookShelfs
            // 
            dgvShowBookShelfs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowBookShelfs.Dock = DockStyle.Fill;
            dgvShowBookShelfs.Location = new Point(0, 0);
            dgvShowBookShelfs.Name = "dgvShowBookShelfs";
            dgvShowBookShelfs.RowHeadersWidth = 51;
            dgvShowBookShelfs.Size = new Size(1240, 231);
            dgvShowBookShelfs.TabIndex = 0;
            dgvShowBookShelfs.CellContentClick += dgvShowBookShelfs_CellContentClick;
            // 
            // dgvBookshelf
            // 
            dgvBookshelf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookshelf.Columns.AddRange(new DataGridViewColumn[] { BookShelfPersonal, SelecBookshelf, DeleteBookShelf });
            dgvBookshelf.Location = new Point(850, 88);
            dgvBookshelf.Name = "dgvBookshelf";
            dgvBookshelf.RowHeadersWidth = 51;
            dgvBookshelf.Size = new Size(387, 189);
            dgvBookshelf.TabIndex = 6;
            dgvBookshelf.CellContentClick += dgvBookshelf_CellContentClick;
            // 
            // BookShelfPersonal
            // 
            BookShelfPersonal.HeaderText = "Kệ sách";
            BookShelfPersonal.MinimumWidth = 6;
            BookShelfPersonal.Name = "BookShelfPersonal";
            BookShelfPersonal.Width = 125;
            // 
            // SelecBookshelf
            // 
            SelecBookshelf.HeaderText = "Chọn kệ để chứa sách";
            SelecBookshelf.MinimumWidth = 6;
            SelecBookshelf.Name = "SelecBookshelf";
            SelecBookshelf.Width = 125;
            // 
            // DeleteBookShelf
            // 
            DeleteBookShelf.HeaderText = "xóa";
            DeleteBookShelf.MinimumWidth = 6;
            DeleteBookShelf.Name = "DeleteBookShelf";
            DeleteBookShelf.Resizable = DataGridViewTriState.True;
            DeleteBookShelf.SortMode = DataGridViewColumnSortMode.Automatic;
            DeleteBookShelf.UseColumnTextForButtonValue = true;
            DeleteBookShelf.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1240, 46);
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
            menuStrip1.Size = new Size(1240, 33);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(4, 284);
            label1.Name = "label1";
            label1.Size = new Size(250, 25);
            label1.TabIndex = 8;
            label1.Text = "Sách trong các kệ sách:";
            // 
            // SearchScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1264, 626);
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
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvShowBookShelfs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookshelf).EndInit();
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
        private DataGridView dgvBookshelf;
        private System.Windows.Forms.Timer timer;
        private DataGridViewTextBoxColumn BookShelfPersonal;
        private DataGridViewCheckBoxColumn SelecBookshelf;
        private DataGridViewButtonColumn DeleteBookShelf;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Authors;
        private DataGridViewTextBoxColumn PublishedDate;
        private DataGridViewTextBoxColumn isbn;
        private DataGridViewButtonColumn selecBook;
        private Panel panel3;
        private DataGridView dgvShowBookShelfs;
        private Label label1;
    }
}