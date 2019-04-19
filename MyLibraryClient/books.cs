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
    public partial class books : Form
    {
        public books()
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
                        SqlCommand command = new SqlCommand("SELECT * FROM [BOOKS]", connection);
                        sql_reader = command.ExecuteReader();
                        while (sql_reader.Read())
                        {
                            ListViewItem item = new ListViewItem(Convert.ToString(sql_reader["id_book"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Name"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Authors"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Publisher"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Year_of_publication"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Genre"]));
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

        private void add_book()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    if ((!string.IsNullOrEmpty(input_book_name.Text)) && (!string.IsNullOrWhiteSpace(input_book_name.Text)) &&
                        (!string.IsNullOrEmpty(input_author_id.Text)) && (!string.IsNullOrWhiteSpace(input_author_id.Text)) &&
                        (!string.IsNullOrEmpty(input_publisher_id.Text)) && (!string.IsNullOrWhiteSpace(input_publisher_id.Text)))
                    {
                        if ((!string.IsNullOrEmpty(input_year_of_publication.Text)) && (!string.IsNullOrWhiteSpace(input_year_of_publication.Text)) &&
                        (!string.IsNullOrEmpty(input_genre_id.Text)) && (!string.IsNullOrWhiteSpace(input_genre_id.Text)))
                        {
                            SqlCommand command = new SqlCommand("INSERT INTO [BOOKS] (Name, Authors, Publisher, Year_of_publication, Genre) " +
                                                                "VALUES (@Name, @Authors, @Publisher, @Year_of_publication, @Genre)", connection);
                            command.Parameters.AddWithValue("Name", input_book_name.Text);
                            command.Parameters.AddWithValue("Authors", int.Parse(input_author_id.Text));
                            command.Parameters.AddWithValue("Publisher", int.Parse(input_publisher_id.Text));
                            command.Parameters.AddWithValue("Year_of_publication", short.Parse(input_year_of_publication.Text));
                            command.Parameters.AddWithValue("Genre", int.Parse(input_genre_id.Text));
                            command.ExecuteNonQuery();
                            input_book_name.Clear();
                            input_author_id.Clear();
                            input_publisher_id.Clear();
                            input_year_of_publication.Clear();
                            input_genre_id.Clear();
                        }
                        else if ((!string.IsNullOrEmpty(input_year_of_publication.Text)) && (!string.IsNullOrWhiteSpace(input_year_of_publication.Text)) &&
                        (string.IsNullOrEmpty(input_genre_id.Text)) || (string.IsNullOrWhiteSpace(input_genre_id.Text)))
                        {
                            SqlCommand command = new SqlCommand("INSERT INTO [BOOKS] (Name, Authors, Publisher, Year_of_publication) " +
                                                                "VALUES (@Name, @Authors, @Publisher, @Year_of_publication)", connection);
                            command.Parameters.AddWithValue("Name", input_book_name.Text);
                            command.Parameters.AddWithValue("Author", input_author_id.Text);
                            command.Parameters.AddWithValue("Publisher", input_publisher_id.Text);
                            command.Parameters.AddWithValue("Year_of_publication", input_year_of_publication.Text);
                            command.ExecuteNonQuery();
                            input_book_name.Clear();
                            input_author_id.Clear();
                            input_publisher_id.Clear();
                            input_year_of_publication.Clear();
                        }
                        else if ((string.IsNullOrEmpty(input_year_of_publication.Text)) || (string.IsNullOrWhiteSpace(input_year_of_publication.Text)) &&
                        (!string.IsNullOrEmpty(input_genre_id.Text)) && (!string.IsNullOrWhiteSpace(input_genre_id.Text)))
                        {
                            SqlCommand command = new SqlCommand("INSERT INTO [BOOKS] (Name, Authors, Publisher, Year_of_publication, Genre) " +
                                                                "VALUES (@Name, @Authors, @Publisher, @Genre)", connection);
                            command.Parameters.AddWithValue("Name", input_book_name.Text);
                            command.Parameters.AddWithValue("Author", input_author_id.Text);
                            command.Parameters.AddWithValue("Publisher", input_publisher_id.Text);
                            command.Parameters.AddWithValue("Genre", input_genre_id.Text);
                            command.ExecuteNonQuery();
                            input_book_name.Clear();
                            input_author_id.Clear();
                            input_publisher_id.Clear();
                            input_genre_id.Clear();
                        }
                        else if ((string.IsNullOrEmpty(input_year_of_publication.Text)) || (string.IsNullOrWhiteSpace(input_year_of_publication.Text)) &&
                        (string.IsNullOrEmpty(input_genre_id.Text)) || (string.IsNullOrWhiteSpace(input_genre_id.Text)))
                        {
                            SqlCommand command = new SqlCommand("INSERT INTO [BOOKS] (Name, Authors, Publisher, Year_of_publication, Genre) " +
                                                                "VALUES (@Name, @Authors, @Publisher)", connection);
                            command.Parameters.AddWithValue("Name", input_book_name.Text);
                            command.Parameters.AddWithValue("Author", input_author_id.Text);
                            command.Parameters.AddWithValue("Publisher", input_publisher_id.Text);
                            command.ExecuteNonQuery();
                            input_book_name.Clear();
                            input_author_id.Clear();
                            input_publisher_id.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Поля 'Название', 'Авторы' и 'Издательство' должны быть заполнены!");
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
            add_book();
        }
    }
}