namespace MyLibraryClient
{
    partial class books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(books));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.add_button = new System.Windows.Forms.Button();
            this.input_publisher_id = new System.Windows.Forms.TextBox();
            this.input_genre_id = new System.Windows.Forms.TextBox();
            this.input_year_of_publication = new System.Windows.Forms.TextBox();
            this.input_author_id = new System.Windows.Forms.TextBox();
            this.input_book_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.book_name = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 482);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.refresh_button);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(820, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список книг";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.add_button);
            this.tabPage2.Controls.Add(this.input_publisher_id);
            this.tabPage2.Controls.Add(this.input_genre_id);
            this.tabPage2.Controls.Add(this.input_year_of_publication);
            this.tabPage2.Controls.Add(this.input_author_id);
            this.tabPage2.Controls.Add(this.input_book_name);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.book_name);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(820, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(591, 181);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(135, 43);
            this.add_button.TabIndex = 25;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // input_publisher_id
            // 
            this.input_publisher_id.Location = new System.Drawing.Point(291, 292);
            this.input_publisher_id.Name = "input_publisher_id";
            this.input_publisher_id.Size = new System.Drawing.Size(218, 31);
            this.input_publisher_id.TabIndex = 24;
            // 
            // input_genre_id
            // 
            this.input_genre_id.Location = new System.Drawing.Point(291, 239);
            this.input_genre_id.Name = "input_genre_id";
            this.input_genre_id.Size = new System.Drawing.Size(218, 31);
            this.input_genre_id.TabIndex = 23;
            // 
            // input_year_of_publication
            // 
            this.input_year_of_publication.Location = new System.Drawing.Point(291, 187);
            this.input_year_of_publication.Name = "input_year_of_publication";
            this.input_year_of_publication.Size = new System.Drawing.Size(218, 31);
            this.input_year_of_publication.TabIndex = 22;
            // 
            // input_author_id
            // 
            this.input_author_id.Location = new System.Drawing.Point(291, 134);
            this.input_author_id.Name = "input_author_id";
            this.input_author_id.Size = new System.Drawing.Size(218, 31);
            this.input_author_id.TabIndex = 21;
            // 
            // input_book_name
            // 
            this.input_book_name.Location = new System.Drawing.Point(291, 82);
            this.input_book_name.Name = "input_book_name";
            this.input_book_name.Size = new System.Drawing.Size(218, 31);
            this.input_book_name.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "ID Издательства";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID Жанра";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Год публикации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID автора";
            // 
            // book_name
            // 
            this.book_name.AutoSize = true;
            this.book_name.Location = new System.Drawing.Point(69, 82);
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(109, 25);
            this.book_name.TabIndex = 15;
            this.book_name.Text = "Название";
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(-8, 364);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(836, 79);
            this.refresh_button.TabIndex = 3;
            this.refresh_button.TabStop = false;
            this.refresh_button.Text = "Обновить";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(820, 364);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Авторы";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Издательство";
            this.columnHeader4.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Год публикации";
            this.columnHeader5.Width = 96;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Жанр";
            this.columnHeader6.Width = 70;
            // 
            // books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 482);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "books";
            this.Text = "Книги";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox input_publisher_id;
        private System.Windows.Forms.TextBox input_genre_id;
        private System.Windows.Forms.TextBox input_year_of_publication;
        private System.Windows.Forms.TextBox input_author_id;
        private System.Windows.Forms.TextBox input_book_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label book_name;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}