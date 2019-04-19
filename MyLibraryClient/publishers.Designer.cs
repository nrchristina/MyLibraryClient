namespace MyLibraryClient
{
    partial class publishers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(publishers));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.refresh_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.add_button = new System.Windows.Forms.Button();
            this.input_city = new System.Windows.Forms.TextBox();
            this.input_publisher_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.refresh_button);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список издательств";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(0, 303);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(784, 76);
            this.refresh_button.TabIndex = 1;
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
            this.listView1.Location = new System.Drawing.Point(0, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(784, 300);
            this.listView1.TabIndex = 2;
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
            this.columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Город";
            this.columnHeader3.Width = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.add_button);
            this.tabPage2.Controls.Add(this.input_city);
            this.tabPage2.Controls.Add(this.input_publisher_name);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(569, 158);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(141, 43);
            this.add_button.TabIndex = 25;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // input_city
            // 
            this.input_city.Location = new System.Drawing.Point(291, 187);
            this.input_city.Name = "input_city";
            this.input_city.Size = new System.Drawing.Size(218, 31);
            this.input_city.TabIndex = 22;
            // 
            // input_publisher_name
            // 
            this.input_publisher_name.Location = new System.Drawing.Point(291, 134);
            this.input_publisher_name.Name = "input_publisher_name";
            this.input_publisher_name.Size = new System.Drawing.Size(218, 31);
            this.input_publisher_name.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Город";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Название";
            // 
            // publishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "publishers";
            this.Text = "Издательства";
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
        private System.Windows.Forms.TextBox input_city;
        private System.Windows.Forms.TextBox input_publisher_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}