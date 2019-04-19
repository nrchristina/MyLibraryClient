namespace MyLibraryClient
{
    partial class output
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(output));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.add_button = new System.Windows.Forms.Button();
            this.input_reader_id = new System.Windows.Forms.TextBox();
            this.input_book_id = new System.Windows.Forms.TextBox();
            this.input_return_date = new System.Windows.Forms.TextBox();
            this.input_output_date = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.input_fine = new System.Windows.Forms.TextBox();
            this.fine_id = new System.Windows.Forms.Label();
            this.add_fine_button = new System.Windows.Forms.Button();
            this.input_actual_return_date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.alter_button = new System.Windows.Forms.Button();
            this.input_iutput_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.tabControl1.Location = new System.Drawing.Point(-2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 554);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(858, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список выдач";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(852, 501);
            this.listBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.add_button);
            this.tabPage2.Controls.Add(this.input_reader_id);
            this.tabPage2.Controls.Add(this.input_book_id);
            this.tabPage2.Controls.Add(this.input_return_date);
            this.tabPage2.Controls.Add(this.input_output_date);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выдать книгу";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(629, 159);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(127, 43);
            this.add_button.TabIndex = 25;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // input_reader_id
            // 
            this.input_reader_id.Location = new System.Drawing.Point(337, 245);
            this.input_reader_id.Name = "input_reader_id";
            this.input_reader_id.Size = new System.Drawing.Size(218, 31);
            this.input_reader_id.TabIndex = 23;
            // 
            // input_book_id
            // 
            this.input_book_id.Location = new System.Drawing.Point(337, 193);
            this.input_book_id.Name = "input_book_id";
            this.input_book_id.Size = new System.Drawing.Size(218, 31);
            this.input_book_id.TabIndex = 22;
            // 
            // input_return_date
            // 
            this.input_return_date.Location = new System.Drawing.Point(337, 140);
            this.input_return_date.Name = "input_return_date";
            this.input_return_date.Size = new System.Drawing.Size(218, 31);
            this.input_return_date.TabIndex = 21;
            // 
            // input_output_date
            // 
            this.input_output_date.Location = new System.Drawing.Point(337, 88);
            this.input_output_date.Name = "input_output_date";
            this.input_output_date.Size = new System.Drawing.Size(218, 31);
            this.input_output_date.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID читателя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Дата возврата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Дата выдачи";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.input_fine);
            this.tabPage3.Controls.Add(this.fine_id);
            this.tabPage3.Controls.Add(this.add_fine_button);
            this.tabPage3.Controls.Add(this.input_actual_return_date);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.alter_button);
            this.tabPage3.Controls.Add(this.input_iutput_id);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(858, 507);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Изменить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // input_fine
            // 
            this.input_fine.Location = new System.Drawing.Point(304, 290);
            this.input_fine.Name = "input_fine";
            this.input_fine.Size = new System.Drawing.Size(218, 31);
            this.input_fine.TabIndex = 36;
            // 
            // fine_id
            // 
            this.fine_id.AutoSize = true;
            this.fine_id.Location = new System.Drawing.Point(108, 293);
            this.fine_id.Name = "fine_id";
            this.fine_id.Size = new System.Drawing.Size(118, 25);
            this.fine_id.TabIndex = 35;
            this.fine_id.Text = "ID штрафа";
            // 
            // add_fine_button
            // 
            this.add_fine_button.Location = new System.Drawing.Point(113, 284);
            this.add_fine_button.Name = "add_fine_button";
            this.add_fine_button.Size = new System.Drawing.Size(243, 43);
            this.add_fine_button.TabIndex = 34;
            this.add_fine_button.Text = "Добавить штраф";
            this.add_fine_button.UseVisualStyleBackColor = true;
            this.add_fine_button.Click += new System.EventHandler(this.add_fine_button_Click);
            // 
            // input_actual_return_date
            // 
            this.input_actual_return_date.Location = new System.Drawing.Point(304, 228);
            this.input_actual_return_date.Name = "input_actual_return_date";
            this.input_actual_return_date.Size = new System.Drawing.Size(218, 31);
            this.input_actual_return_date.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Дата возврата";
            // 
            // alter_button
            // 
            this.alter_button.Location = new System.Drawing.Point(618, 157);
            this.alter_button.Name = "alter_button";
            this.alter_button.Size = new System.Drawing.Size(133, 43);
            this.alter_button.TabIndex = 31;
            this.alter_button.Text = "Изменить";
            this.alter_button.UseVisualStyleBackColor = true;
            // 
            // input_iutput_id
            // 
            this.input_iutput_id.Location = new System.Drawing.Point(304, 163);
            this.input_iutput_id.Name = "input_iutput_id";
            this.input_iutput_id.Size = new System.Drawing.Size(218, 31);
            this.input_iutput_id.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID выдачи";
            // 
            // output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 556);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "output";
            this.Text = "Выдача";
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox input_reader_id;
        private System.Windows.Forms.TextBox input_book_id;
        private System.Windows.Forms.TextBox input_return_date;
        private System.Windows.Forms.TextBox input_output_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button alter_button;
        private System.Windows.Forms.TextBox input_iutput_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_fine;
        private System.Windows.Forms.Label fine_id;
        private System.Windows.Forms.Button add_fine_button;
        private System.Windows.Forms.TextBox input_actual_return_date;
        private System.Windows.Forms.Label label4;
    }
}