﻿namespace MyLibraryClient
{
    partial class subscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subscription));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.add_button = new System.Windows.Forms.Button();
            this.input_subscription_price = new System.Windows.Forms.TextBox();
            this.input_subscription_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.input_subscription_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.alter_button = new System.Windows.Forms.Button();
            this.input_alter_subscription_price = new System.Windows.Forms.TextBox();
            this.input_alter_subscription_description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.delete_button = new System.Windows.Forms.Button();
            this.input_delete_subscription_id = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Виды абонементов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(778, 397);
            this.listBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.add_button);
            this.tabPage2.Controls.Add(this.input_subscription_price);
            this.tabPage2.Controls.Add(this.input_subscription_description);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(587, 155);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(137, 43);
            this.add_button.TabIndex = 25;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // input_subscription_price
            // 
            this.input_subscription_price.Location = new System.Drawing.Point(317, 186);
            this.input_subscription_price.Name = "input_subscription_price";
            this.input_subscription_price.Size = new System.Drawing.Size(218, 31);
            this.input_subscription_price.TabIndex = 21;
            this.input_subscription_price.TextChanged += new System.EventHandler(this.input_author_name_TextChanged);
            // 
            // input_subscription_description
            // 
            this.input_subscription_description.Location = new System.Drawing.Point(317, 134);
            this.input_subscription_description.Name = "input_subscription_description";
            this.input_subscription_description.Size = new System.Drawing.Size(218, 31);
            this.input_subscription_description.TabIndex = 20;
            this.input_subscription_description.TextChanged += new System.EventHandler(this.input_book_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Цена абонемента";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Описание абонемента";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.input_subscription_id);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.alter_button);
            this.tabPage3.Controls.Add(this.input_alter_subscription_price);
            this.tabPage3.Controls.Add(this.input_alter_subscription_description);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(784, 403);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Изменить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // input_subscription_id
            // 
            this.input_subscription_id.Location = new System.Drawing.Point(297, 122);
            this.input_subscription_id.Name = "input_subscription_id";
            this.input_subscription_id.Size = new System.Drawing.Size(218, 31);
            this.input_subscription_id.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "ID абонемента";
            // 
            // alter_button
            // 
            this.alter_button.Location = new System.Drawing.Point(571, 173);
            this.alter_button.Name = "alter_button";
            this.alter_button.Size = new System.Drawing.Size(133, 43);
            this.alter_button.TabIndex = 30;
            this.alter_button.Text = "Изменить";
            this.alter_button.UseVisualStyleBackColor = true;
            // 
            // input_alter_subscription_price
            // 
            this.input_alter_subscription_price.Location = new System.Drawing.Point(297, 231);
            this.input_alter_subscription_price.Name = "input_alter_subscription_price";
            this.input_alter_subscription_price.Size = new System.Drawing.Size(218, 31);
            this.input_alter_subscription_price.TabIndex = 29;
            // 
            // input_alter_subscription_description
            // 
            this.input_alter_subscription_description.Location = new System.Drawing.Point(297, 179);
            this.input_alter_subscription_description.Name = "input_alter_subscription_description";
            this.input_alter_subscription_description.Size = new System.Drawing.Size(218, 31);
            this.input_alter_subscription_description.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Описание ";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.delete_button);
            this.tabPage4.Controls.Add(this.input_delete_subscription_id);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(784, 403);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Удалить";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(590, 163);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(127, 43);
            this.delete_button.TabIndex = 31;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // input_delete_subscription_id
            // 
            this.input_delete_subscription_id.Location = new System.Drawing.Point(282, 169);
            this.input_delete_subscription_id.Name = "input_delete_subscription_id";
            this.input_delete_subscription_id.Size = new System.Drawing.Size(218, 31);
            this.input_delete_subscription_id.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID абонемента";
            // 
            // subscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subscription";
            this.Text = "Абонементы";
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox input_subscription_price;
        private System.Windows.Forms.TextBox input_subscription_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button alter_button;
        private System.Windows.Forms.TextBox input_alter_subscription_price;
        private System.Windows.Forms.TextBox input_alter_subscription_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox input_delete_subscription_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_subscription_id;
        private System.Windows.Forms.Label label6;
    }
}