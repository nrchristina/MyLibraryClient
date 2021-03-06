﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryClient
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        public void enter_Click(object sender, EventArgs e)
        {
            Bridge.bridge = new Bridge(enter_name.Text, password.Text);
            Connector.str_connection = Bridge.bridge.GetConnectionString();
            if (string.IsNullOrEmpty(enter_name.Text) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Введите логин и парооль");
                return;
            }
            else
            {
                Bridge.bridge = new Bridge(enter_name.Text, password.Text);
                using (var connection = Bridge.bridge.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        var main_form = new main_form();
                        Hide();
                        main_form.ShowDialog();
                        password.Text = string.Empty;
                        Show();
                    }
                    catch (Exception)
                    {
                        password.Text = string.Empty;
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
        }
    }
}
