﻿namespace MyLibraryClient
{
    partial class fine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fine));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.refresh_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.add_button = new System.Windows.Forms.Button();
            this.input_fine_price = new System.Windows.Forms.TextBox();
            this.input_fine_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.input_alter_fine_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.alter_button = new System.Windows.Forms.Button();
            this.input_alter_fine_price = new System.Windows.Forms.TextBox();
            this.input_alter_fine_description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.delete_button = new System.Windows.Forms.Button();
            this.input_delete_fine_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 340);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.refresh_button);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(858, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список штрафов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(0, 217);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(858, 76);
            this.refresh_button.TabIndex = 4;
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
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(858, 218);
            this.listView1.TabIndex = 3;
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
            this.columnHeader2.Text = "Описание";
            this.columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Размер";
            this.columnHeader3.Width = 154;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.add_button);
            this.tabPage2.Controls.Add(this.input_fine_price);
            this.tabPage2.Controls.Add(this.input_fine_description);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(620, 129);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(133, 43);
            this.add_button.TabIndex = 25;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // input_fine_price
            // 
            this.input_fine_price.Location = new System.Drawing.Point(339, 160);
            this.input_fine_price.Name = "input_fine_price";
            this.input_fine_price.Size = new System.Drawing.Size(218, 31);
            this.input_fine_price.TabIndex = 21;
            // 
            // input_fine_description
            // 
            this.input_fine_description.Location = new System.Drawing.Point(339, 108);
            this.input_fine_description.Name = "input_fine_description";
            this.input_fine_description.Size = new System.Drawing.Size(218, 31);
            this.input_fine_description.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Размер штрафа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Описание штрафа";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.input_alter_fine_id);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.alter_button);
            this.tabPage3.Controls.Add(this.input_alter_fine_price);
            this.tabPage3.Controls.Add(this.input_alter_fine_description);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(858, 293);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Изменить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // input_alter_fine_id
            // 
            this.input_alter_fine_id.Location = new System.Drawing.Point(335, 83);
            this.input_alter_fine_id.Name = "input_alter_fine_id";
            this.input_alter_fine_id.Size = new System.Drawing.Size(218, 31);
            this.input_alter_fine_id.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "ID штрафа";
            // 
            // alter_button
            // 
            this.alter_button.Location = new System.Drawing.Point(616, 129);
            this.alter_button.Name = "alter_button";
            this.alter_button.Size = new System.Drawing.Size(133, 43);
            this.alter_button.TabIndex = 30;
            this.alter_button.Text = "Изменить";
            this.alter_button.UseVisualStyleBackColor = true;
            this.alter_button.Click += new System.EventHandler(this.alter_button_Click);
            // 
            // input_alter_fine_price
            // 
            this.input_alter_fine_price.Location = new System.Drawing.Point(335, 187);
            this.input_alter_fine_price.Name = "input_alter_fine_price";
            this.input_alter_fine_price.Size = new System.Drawing.Size(218, 31);
            this.input_alter_fine_price.TabIndex = 29;
            // 
            // input_alter_fine_description
            // 
            this.input_alter_fine_description.Location = new System.Drawing.Point(335, 135);
            this.input_alter_fine_description.Name = "input_alter_fine_description";
            this.input_alter_fine_description.Size = new System.Drawing.Size(218, 31);
            this.input_alter_fine_description.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Размер штрафа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Описание штрафа";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.delete_button);
            this.tabPage4.Controls.Add(this.input_delete_fine_id);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(858, 293);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Удалить";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(632, 121);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(127, 44);
            this.delete_button.TabIndex = 31;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // input_delete_fine_id
            // 
            this.input_delete_fine_id.Location = new System.Drawing.Point(324, 127);
            this.input_delete_fine_id.Name = "input_delete_fine_id";
            this.input_delete_fine_id.Size = new System.Drawing.Size(218, 31);
            this.input_delete_fine_id.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID штрафа";
            // 
            // fine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 340);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fine";
            this.Text = "Штрафы";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox input_fine_price;
        private System.Windows.Forms.TextBox input_fine_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button alter_button;
        private System.Windows.Forms.TextBox input_alter_fine_price;
        private System.Windows.Forms.TextBox input_alter_fine_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox input_delete_fine_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_alter_fine_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button refresh_button;
    }
}