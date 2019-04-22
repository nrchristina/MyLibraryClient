using System;
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
    public partial class subscription : Form
    {
        public subscription()
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
                        SqlCommand command = new SqlCommand("SELECT * FROM [SUBSCRIPTION]", connection);
                        sql_reader = command.ExecuteReader();
                        while (sql_reader.Read())
                        {
                            ListViewItem item = new ListViewItem(Convert.ToString(sql_reader["id_subscription"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["description"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["price"]));
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

        private void add_subscription()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    if ((!string.IsNullOrEmpty(input_subscription_description.Text)) && (!string.IsNullOrWhiteSpace(input_subscription_description.Text)) &&
                        (!string.IsNullOrEmpty(input_subscription_price.Text)) && (!string.IsNullOrWhiteSpace(input_subscription_price.Text)))
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO [SUBSCRIPTION] (description, price) VALUES (@description, @price)", connection);
                        command.Parameters.AddWithValue("description", input_subscription_description.Text);
                        command.Parameters.AddWithValue("price", input_subscription_price.Text);
                        command.ExecuteNonQuery();
                        input_subscription_description.Clear();
                        input_subscription_price.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Поля 'Описание' и 'Цена' должны быть заполнены!");
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
            add_subscription();
        }

        private void alter_subscription()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    if ((!string.IsNullOrEmpty(input_subscription_id.Text)) && (!string.IsNullOrWhiteSpace(input_subscription_id.Text)) &&
                        (!string.IsNullOrEmpty(input_alter_subscription_description.Text)) && (!string.IsNullOrWhiteSpace(input_alter_subscription_description.Text)) &&
                        (!string.IsNullOrEmpty(input_alter_subscription_price.Text)) && (!string.IsNullOrWhiteSpace(input_alter_subscription_price.Text)))
                    {
                        SqlCommand command = new SqlCommand("UPDATE [SUBSCRIPTION] SET [description]=@description, [price]=@price WHERE [id_fine]=@id_fine", connection);
                        command.Parameters.AddWithValue("id_fine", input_subscription_id.Text);
                        command.Parameters.AddWithValue("description", input_alter_subscription_description.Text);
                        command.Parameters.AddWithValue("price", input_alter_subscription_price.Text);
                        command.ExecuteNonQuery();
                        input_subscription_id.Clear();
                        input_alter_subscription_description.Clear();
                        input_alter_subscription_price.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Поля 'ID', 'Описание' и 'Цена' должны быть заполнены!");
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString());
            }
        }

        private void alter_button_Click(object sender, EventArgs e)
        {
            alter_subscription();
        }

        private void delete_subscription()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    if ((!string.IsNullOrEmpty(input_delete_subscription_id.Text)) && (!string.IsNullOrWhiteSpace(input_delete_subscription_id.Text)))
                    {
                        SqlCommand command = new SqlCommand("DELETE FROM [SUBSCRIPTION] WHERE [id_fine]=@id_fine", connection);
                        command.Parameters.AddWithValue("id_fine", input_delete_subscription_id.Text);
                        command.ExecuteNonQuery();
                        input_delete_subscription_id.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Полe 'ID' должно быть заполнено!");
                    }
                    connection.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString());
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            delete_subscription();
        }
    }
}
