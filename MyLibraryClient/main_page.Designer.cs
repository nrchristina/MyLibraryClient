namespace MyLibraryClient
{
    partial class main_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.books_button = new System.Windows.Forms.Button();
            this.readers_button = new System.Windows.Forms.Button();
            this.output_button = new System.Windows.Forms.Button();
            this.fines_button = new System.Windows.Forms.Button();
            this.publishers_button = new System.Windows.Forms.Button();
            this.genres_button = new System.Windows.Forms.Button();
            this.authors_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.archive_button = new System.Windows.Forms.Button();
            this.subcrciption_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // books_button
            // 
            this.books_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.books_button.Location = new System.Drawing.Point(40, 43);
            this.books_button.Margin = new System.Windows.Forms.Padding(2);
            this.books_button.Name = "books_button";
            this.books_button.Size = new System.Drawing.Size(130, 43);
            this.books_button.TabIndex = 0;
            this.books_button.Text = "Книги";
            this.books_button.UseVisualStyleBackColor = true;
            this.books_button.Click += new System.EventHandler(this.books_button_Click);
            // 
            // readers_button
            // 
            this.readers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readers_button.Location = new System.Drawing.Point(40, 114);
            this.readers_button.Margin = new System.Windows.Forms.Padding(2);
            this.readers_button.Name = "readers_button";
            this.readers_button.Size = new System.Drawing.Size(130, 43);
            this.readers_button.TabIndex = 1;
            this.readers_button.Text = "Читатели";
            this.readers_button.UseVisualStyleBackColor = true;
            this.readers_button.Click += new System.EventHandler(this.readers_button_Click);
            // 
            // output_button
            // 
            this.output_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output_button.Location = new System.Drawing.Point(40, 186);
            this.output_button.Margin = new System.Windows.Forms.Padding(2);
            this.output_button.Name = "output_button";
            this.output_button.Size = new System.Drawing.Size(130, 43);
            this.output_button.TabIndex = 2;
            this.output_button.Text = "Выдача";
            this.output_button.UseVisualStyleBackColor = true;
            this.output_button.Click += new System.EventHandler(this.output_button_Click);
            // 
            // fines_button
            // 
            this.fines_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fines_button.Location = new System.Drawing.Point(40, 258);
            this.fines_button.Margin = new System.Windows.Forms.Padding(2);
            this.fines_button.Name = "fines_button";
            this.fines_button.Size = new System.Drawing.Size(130, 43);
            this.fines_button.TabIndex = 3;
            this.fines_button.Text = "Штрафы";
            this.fines_button.UseVisualStyleBackColor = true;
            this.fines_button.Click += new System.EventHandler(this.fines_button_Click);
            // 
            // publishers_button
            // 
            this.publishers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publishers_button.Location = new System.Drawing.Point(200, 186);
            this.publishers_button.Margin = new System.Windows.Forms.Padding(2);
            this.publishers_button.Name = "publishers_button";
            this.publishers_button.Size = new System.Drawing.Size(130, 43);
            this.publishers_button.TabIndex = 7;
            this.publishers_button.Text = "Издательства";
            this.publishers_button.UseVisualStyleBackColor = true;
            this.publishers_button.Click += new System.EventHandler(this.publishers_button_Click);
            // 
            // genres_button
            // 
            this.genres_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genres_button.Location = new System.Drawing.Point(200, 114);
            this.genres_button.Margin = new System.Windows.Forms.Padding(2);
            this.genres_button.Name = "genres_button";
            this.genres_button.Size = new System.Drawing.Size(130, 43);
            this.genres_button.TabIndex = 5;
            this.genres_button.Text = "Жанры";
            this.genres_button.UseVisualStyleBackColor = true;
            this.genres_button.Click += new System.EventHandler(this.genres_button_Click);
            // 
            // authors_button
            // 
            this.authors_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authors_button.Location = new System.Drawing.Point(200, 43);
            this.authors_button.Margin = new System.Windows.Forms.Padding(2);
            this.authors_button.Name = "authors_button";
            this.authors_button.Size = new System.Drawing.Size(130, 43);
            this.authors_button.TabIndex = 4;
            this.authors_button.Text = "Авторы";
            this.authors_button.UseVisualStyleBackColor = true;
            this.authors_button.Click += new System.EventHandler(this.authors_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.Location = new System.Drawing.Point(40, 400);
            this.exit_button.Margin = new System.Windows.Forms.Padding(2);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(289, 43);
            this.exit_button.TabIndex = 8;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // archive_button
            // 
            this.archive_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.archive_button.Location = new System.Drawing.Point(199, 258);
            this.archive_button.Margin = new System.Windows.Forms.Padding(2);
            this.archive_button.Name = "archive_button";
            this.archive_button.Size = new System.Drawing.Size(130, 43);
            this.archive_button.TabIndex = 9;
            this.archive_button.Text = "Архив";
            this.archive_button.UseVisualStyleBackColor = true;
            this.archive_button.Click += new System.EventHandler(this.archive_button_Click);
            // 
            // subcrciption_button
            // 
            this.subcrciption_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subcrciption_button.Location = new System.Drawing.Point(40, 329);
            this.subcrciption_button.Margin = new System.Windows.Forms.Padding(2);
            this.subcrciption_button.Name = "subcrciption_button";
            this.subcrciption_button.Size = new System.Drawing.Size(289, 43);
            this.subcrciption_button.TabIndex = 10;
            this.subcrciption_button.Text = "Абонементы";
            this.subcrciption_button.UseVisualStyleBackColor = true;
            this.subcrciption_button.Click += new System.EventHandler(this.subcrciption_button_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 469);
            this.Controls.Add(this.subcrciption_button);
            this.Controls.Add(this.archive_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.publishers_button);
            this.Controls.Add(this.genres_button);
            this.Controls.Add(this.authors_button);
            this.Controls.Add(this.fines_button);
            this.Controls.Add(this.output_button);
            this.Controls.Add(this.readers_button);
            this.Controls.Add(this.books_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.Text = "Главная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_form_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button books_button;
        private System.Windows.Forms.Button readers_button;
        private System.Windows.Forms.Button output_button;
        private System.Windows.Forms.Button fines_button;
        private System.Windows.Forms.Button publishers_button;
        private System.Windows.Forms.Button genres_button;
        private System.Windows.Forms.Button authors_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button archive_button;
        private System.Windows.Forms.Button subcrciption_button;
    }
}

