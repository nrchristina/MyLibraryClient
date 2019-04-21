namespace MyLibraryClient
{
    partial class start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            this.user_name = new System.Windows.Forms.Label();
            this.user_password = new System.Windows.Forms.Label();
            this.enter_name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(86, 93);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(53, 25);
            this.user_name.TabIndex = 0;
            this.user_name.Text = "Имя";
            // 
            // user_password
            // 
            this.user_password.AutoSize = true;
            this.user_password.Location = new System.Drawing.Point(86, 173);
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(86, 25);
            this.user_password.TabIndex = 1;
            this.user_password.Text = "Пароль";
            // 
            // enter_name
            // 
            this.enter_name.Location = new System.Drawing.Point(253, 93);
            this.enter_name.Name = "enter_name";
            this.enter_name.Size = new System.Drawing.Size(222, 31);
            this.enter_name.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(253, 173);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(222, 31);
            this.password.TabIndex = 3;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(223, 256);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(135, 47);
            this.enter.TabIndex = 4;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // start
            // 
            this.AcceptButton = this.enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 360);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.password);
            this.Controls.Add(this.enter_name);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.user_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "start";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label user_password;
        private System.Windows.Forms.TextBox enter_name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button enter;
    }
}