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
                            ListViewItem item = new ListViewItem(Convert.ToString(sql_reader["id_archive"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Name"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Authors"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Publisher"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Year_of_publication"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Genre"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Lost_by"]));
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
    }
}
