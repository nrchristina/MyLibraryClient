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
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.delete_button = new System.Windows.Forms.Button();
            this.input_delete_book_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 482);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(820, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список книг";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(814, 429);
            this.listBox1.TabIndex = 0;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.delete_button);
            this.tabPage3.Controls.Add(this.input_delete_book_id);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(820, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удалить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(626, 152);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(127, 43);
            this.delete_button.TabIndex = 28;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // input_delete_book_id
            // 
            this.input_delete_book_id.Location = new System.Drawing.Point(306, 158);
            this.input_delete_book_id.Name = "input_delete_book_id";
            this.input_delete_book_id.Size = new System.Drawing.Size(218, 31);
            this.input_delete_book_id.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID книги";
            // 
            // books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 482);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "books";
            this.Text = "Книги";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox input_delete_book_id;
        private System.Windows.Forms.Label label1;
    }
}