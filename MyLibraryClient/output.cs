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
    public partial class output : Form
    {
        public output()
        {
            InitializeComponent();
            information_list();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            input_fine.Hide();
            fine_id.Hide();

        }

        private void add_fine_button_Click(object sender, EventArgs e)
        {
            input_fine.Visible=true;
            fine_id.Visible=true;
            add_fine_button.Hide();
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
                        SqlCommand command = new SqlCommand("SELECT * FROM [OUTPUT]", connection);
                        sql_reader = command.ExecuteReader();
                        while (sql_reader.Read())
                        {
                            ListViewItem item = new ListViewItem(Convert.ToString(sql_reader["id_output"]));
                            item.SubItems.Add(Convert.ToDateTime(sql_reader["output_date"]).ToString("d"));
                            item.SubItems.Add(Convert.ToDateTime(sql_reader["actual_return_date"]).ToString("d"));
                            item.SubItems.Add(Convert.ToString(sql_reader["book"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["reader"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["days"]));
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

        private void add_output()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    if ((!string.IsNullOrEmpty(input_output_date.Text)) && (!string.IsNullOrWhiteSpace(input_output_date.Text)) &&
                        (!string.IsNullOrEmpty(input_return_date.Text)) && (!string.IsNullOrWhiteSpace(input_return_date.Text)) &&
                        (!string.IsNullOrEmpty(input_book_id.Text)) && (!string.IsNullOrWhiteSpace(input_book_id.Text)) &&
                        (!string.IsNullOrEmpty(input_reader_id.Text)) && (!string.IsNullOrWhiteSpace(input_reader_id.Text)))
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO [OUTPUT] (output_date, return_date, book, reader) VALUES (@output_date, @return_date, @book, @reader)", connection);
                        command.Parameters.AddWithValue("output_date", input_output_date.Text);
                        command.Parameters.AddWithValue("return_date", input_return_date.Text);
                        command.Parameters.AddWithValue("book", input_book_id.Text);
                        command.Parameters.AddWithValue("reader", input_reader_id.Text);
                        command.ExecuteNonQuery();
                        input_output_date.Clear();
                        input_return_date.Clear();
                        input_book_id.Clear();
                        input_reader_id.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Все поля должны быть заполнены!");
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
            add_output();
        }

        private void alter_output()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    //рассмотреть случай, когда несколько штрафов
                    if ((!string.IsNullOrEmpty(input_output_id.Text)) && (!string.IsNullOrWhiteSpace(input_output_id.Text)) &&
                        (!string.IsNullOrEmpty(input_actual_return_date.Text)) && (!string.IsNullOrWhiteSpace(input_actual_return_date.Text)) &&
                        (input_fine.Visible) &&
                        (!string.IsNullOrEmpty(input_fine.Text)) && (!string.IsNullOrWhiteSpace(input_fine.Text)))
                    {
                        SqlCommand command = new SqlCommand("UPDATE [OUTPUT] SET [actual_return_date]=@actual_return_date WHERE [id_output]=@id_output", connection);
                        command.Parameters.AddWithValue("id_output", input_output_id.Text);
                        command.Parameters.AddWithValue("actual_return_date", input_actual_return_date.Text);
                        command.ExecuteNonQuery();
                        SqlCommand command_2 = new SqlCommand("UPDATE [FINES] SET [fine]=@input_fine WHERE [output]=@id_output", connection);
                        command_2.Parameters.AddWithValue("id_output", input_output_id.Text);
                        command_2.Parameters.AddWithValue("input_fine", input_fine.Text);
                        command_2.ExecuteNonQuery();
                        input_output_id.Clear();
                        input_actual_return_date.Clear();
                        input_fine.Clear();
                    }
                    else if ((!string.IsNullOrEmpty(input_output_id.Text)) && (!string.IsNullOrWhiteSpace(input_output_id.Text)) &&
                        (!string.IsNullOrEmpty(input_actual_return_date.Text)) && (!string.IsNullOrWhiteSpace(input_actual_return_date.Text)) &&
                        (!input_fine.Visible))
                    {
                        SqlCommand command_3 = new SqlCommand("UPDATE [OUTPUT] SET [actual_return_date]=@actual_return_date WHERE [id_output]=@id_output", connection);
                        command_3.Parameters.AddWithValue("id_output", input_output_id.Text);
                        command_3.Parameters.AddWithValue("actual_return_date", input_actual_return_date.Text);
                        command_3.ExecuteNonQuery();
                        input_output_id.Clear();
                        input_actual_return_date.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Все поля должны быть заполнены!");
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
            alter_output();
        }
    }
}
