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
    public partial class authors : Form
    {
        public authors()
        {
            InitializeComponent();
            information_list();
        }
        string connection_string = Connector.str_connection;
        SqlDataReader sql_reader = null;
        private void information_list()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    try
                    {
                        SqlCommand command = new SqlCommand("SELECT * FROM [AUTHOR]", connection);
                        sql_reader = command.ExecuteReader();
                        while (sql_reader.Read())
                        {
                            ListViewItem item = new ListViewItem(Convert.ToString(sql_reader["id_author"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Name"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Surname"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Fathers_name"]));
                            listView1.Items.Add(item);
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString());
                    }

                    finally
                    {
                        if (sql_reader != null)
                            sql_reader.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString());
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            information_list();
        }

        private void add_author()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    if ((!string.IsNullOrEmpty(input_author_name.Text)) && (!string.IsNullOrWhiteSpace(input_author_name.Text)) &&
                        (!string.IsNullOrEmpty(input_author_surname.Text)) && (!string.IsNullOrWhiteSpace(input_author_surname.Text)) &&
                        (!string.IsNullOrEmpty(input_author_fathersname.Text)) && (!string.IsNullOrWhiteSpace(input_author_fathersname.Text)))
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO [AUTHOR] (Name, Surname, Fathers_name) VALUES (@Name, @Surname, @Fathers_name)", connection);
                        command.Parameters.AddWithValue("Name", input_author_name.Text);
                        command.Parameters.AddWithValue("Surname", input_author_surname.Text);
                        command.Parameters.AddWithValue("Fathers_name", input_author_fathersname.Text);
                        command.ExecuteNonQuery();
                        input_author_name.Clear();
                        input_author_surname.Clear();
                        input_author_fathersname.Clear();
                    }
                    else if ((!string.IsNullOrEmpty(input_author_name.Text)) && (!string.IsNullOrWhiteSpace(input_author_name.Text)) &&
                        (!string.IsNullOrEmpty(input_author_surname.Text)) && (!string.IsNullOrWhiteSpace(input_author_surname.Text)) &&
                        (string.IsNullOrEmpty(input_author_fathersname.Text)) || (string.IsNullOrWhiteSpace(input_author_fathersname.Text)))
                    {
                        SqlCommand command_1 = new SqlCommand("INSERT INTO [AUTHOR] (Name, Surname, Fathers_name) VALUES (@Name, @Surname)", connection);
                        command_1.Parameters.AddWithValue("Name", input_author_name.Text);
                        command_1.Parameters.AddWithValue("Surname", input_author_surname.Text);
                        command_1.ExecuteNonQuery();
                        input_author_name.Clear();
                        input_author_surname.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Поля 'Имя' и 'Фамилия' должны быть заполнены!");
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString());
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            add_author();
        }
    }
}
