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
    public partial class publishers : Form
    {
        public publishers()
        {
            InitializeComponent();
            information_list();
        }
        string connection_string = Connector.str_connection;
        SqlDataReader sql_reader = null;
        public void information_list()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    try
                    {
                        SqlCommand command = new SqlCommand("SELECT * FROM [PUBLISHER]", connection);
                        sql_reader = command.ExecuteReader();
                        while (sql_reader.Read())
                        {
                            //listBox1.Items.Add(Convert.ToString(sql_reader["id_publisher"]) + "  " + Convert.ToString(sql_reader["Name"]) + "  " + Convert.ToString(sql_reader["City"]));
                            ListViewItem item = new ListViewItem(Convert.ToString(sql_reader["id_publisher"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Name"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["City"]));
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
        public void add_publisher()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    if ((!string.IsNullOrEmpty(input_publisher_name.Text)) && (!string.IsNullOrWhiteSpace(input_publisher_name.Text)) &&
                        (!string.IsNullOrEmpty(input_city.Text)) && (!string.IsNullOrWhiteSpace(input_city.Text)))
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO [PUBLISHER] (Name, City) VALUES (@Name, @City)", connection);
                        command.Parameters.AddWithValue("Name", input_publisher_name.Text);
                        command.Parameters.AddWithValue("City", input_city.Text);
                        command.ExecuteNonQuery();
                        input_publisher_name.Clear();
                        input_city.Clear();
                     }
                    else
                    {
                        MessageBox.Show("Пол 'Название' и 'Город' должны быть заполнены!");
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
            add_publisher();
            input_publisher_name.Clear();
            input_city.Clear();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            information_list();
        }

    }
}
