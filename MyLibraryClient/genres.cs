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
    public partial class genres : Form
    {
        public genres()
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
                        SqlCommand command = new SqlCommand("SELECT * FROM [GENRE]", connection);
                        sql_reader = command.ExecuteReader();
                        while (sql_reader.Read())
                        {
                            ListViewItem item = new ListViewItem(Convert.ToString(sql_reader["id_genre"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Name"]));
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

        //в разработке

             private void add_genre()
             {
             try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    if ((!string.IsNullOrEmpty(input_genre_name.Text)) && (!string.IsNullOrWhiteSpace(input_genre_name.Text)) &&
                        (!string.IsNullOrEmpty(input_part_id.Text)) && (!string.IsNullOrWhiteSpace(input_part_id.Text)))
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO [GENRE] (Name) VALUES (@Name)", connection);
                        command.Parameters.AddWithValue("Name", input_genre_name.Text);
                        command.ExecuteNonQuery();
                        input_genre_name.Clear();
                        input_part_id.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Поля 'Жанр' и 'Раздел' должны быть заполнены!");
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
            add_genre();
        }
    }
}
