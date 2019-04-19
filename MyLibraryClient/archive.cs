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
    public partial class archive : Form
    {
        public archive()
        {
            InitializeComponent();
            information_list();
        }
        string connection_string = Connector.str_connection;
        SqlDataReader sql_reader = null;
        public void information_list()
        {

            listBox1.Items.Insert(0, "ID\t" + "Название\t" + "\t" +"Авторы\t" + "Издательство\t" + "Год издания\t" + "Жанр\t" + "Потеряна читателем");
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    try
                    {
                        SqlCommand command = new SqlCommand("SELECT * FROM [ARCHIVE]", connection);
                        sql_reader = command.ExecuteReader();
                        while (sql_reader.Read())
                        {
                            listBox1.Items.Add(Convert.ToString(sql_reader["id_archive"]) + "\t" + Convert.ToString(sql_reader["Name"]) + "\t" + "\t" +
                                Convert.ToString(sql_reader["Authors"]) + "\t" + Convert.ToString(sql_reader["Publisher"]) + "\t" + 
                                Convert.ToString(sql_reader["Year_of_publication"]) + "\t" + Convert.ToString(sql_reader["Genre"])+ "\t" +
                                Convert.ToString(sql_reader["Lost_by"]));
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
    }
}
