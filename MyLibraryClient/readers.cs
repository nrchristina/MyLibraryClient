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
    public partial class readers : Form
    {
        public readers()
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
                        SqlCommand command = new SqlCommand("SELECT * FROM [READER]", connection);
                        sql_reader = command.ExecuteReader();
                        while (sql_reader.Read())
                        {
                            ListViewItem item = new ListViewItem(Convert.ToString(sql_reader["id_reader"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Name"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Surname"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Fathers_name"]));
                            item.SubItems.Add(Convert.ToDateTime(sql_reader["Date_of_Birth"]).ToString("d"));
                            item.SubItems.Add(Convert.ToString(sql_reader["Phone_number"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Email"]));
                            item.SubItems.Add(Convert.ToString(sql_reader["Subscription"]));
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

        private void add_reader()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    if ((!string.IsNullOrEmpty(input_reader_name.Text)) && (!string.IsNullOrWhiteSpace(input_reader_name.Text)) &&
                        (!string.IsNullOrEmpty(input_reader_surname.Text)) && (!string.IsNullOrWhiteSpace(input_reader_surname.Text)) &&
                        (!string.IsNullOrEmpty(input_reader_fathersname.Text)) && (!string.IsNullOrWhiteSpace(input_reader_fathersname.Text)) &&
                        (!string.IsNullOrEmpty(input_reader_birthdate.Text)) && (!string.IsNullOrWhiteSpace(input_reader_birthdate.Text)) &&
                        (!string.IsNullOrEmpty(input_reader_phonenumber.Text)) && (!string.IsNullOrWhiteSpace(input_reader_phonenumber.Text)) &&
                        (!string.IsNullOrEmpty(input_reader_email.Text)) && (!string.IsNullOrWhiteSpace(input_reader_email.Text)) &&
                        (!string.IsNullOrEmpty(input_reader_subscription_id.Text)) && (!string.IsNullOrWhiteSpace(input_reader_subscription_id.Text)))
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO [READER] (Name, Surname, Fathers_name, Date_of_Birth, Phone_number, Email, Subscription) VALUES (@Name, @Surname, @Fathers_name, @Date_of_Birth, @Phone_number, @Email, @Subscription)", connection);
                        command.Parameters.AddWithValue("Name", input_reader_name.Text);
                        command.Parameters.AddWithValue("Surname", input_reader_surname.Text);
                        command.Parameters.AddWithValue("Fathers_name", input_reader_fathersname.Text);
                        command.Parameters.AddWithValue("Date_of_Birth", input_reader_birthdate.Text);
                        command.Parameters.AddWithValue("Phone_number", input_reader_phonenumber.Text);
                        command.Parameters.AddWithValue("Email", input_reader_email.Text);
                        command.Parameters.AddWithValue("Subscription", input_reader_subscription_id.Text);
                        command.ExecuteNonQuery();
                        input_reader_name.Clear();
                        input_reader_surname.Clear();
                        input_reader_fathersname.Clear();
                        input_reader_birthdate.Clear();
                        input_reader_phonenumber.Clear();
                        input_reader_email.Clear();
                        input_reader_subscription_id.Clear();
                    }
                    else if ((!string.IsNullOrEmpty(input_reader_name.Text)) && (!string.IsNullOrWhiteSpace(input_reader_name.Text)) &&
                             (!string.IsNullOrEmpty(input_reader_surname.Text)) && (!string.IsNullOrWhiteSpace(input_reader_surname.Text)) &&
                             (string.IsNullOrEmpty(input_reader_fathersname.Text)) || (string.IsNullOrWhiteSpace(input_reader_fathersname.Text)) &&
                             (!string.IsNullOrEmpty(input_reader_birthdate.Text)) && (!string.IsNullOrWhiteSpace(input_reader_birthdate.Text)) &&
                             (!string.IsNullOrEmpty(input_reader_phonenumber.Text)) && (!string.IsNullOrWhiteSpace(input_reader_phonenumber.Text)) &&
                             (!string.IsNullOrEmpty(input_reader_email.Text)) && (!string.IsNullOrWhiteSpace(input_reader_email.Text)) &&
                             (!string.IsNullOrEmpty(input_reader_subscription_id.Text)) && (!string.IsNullOrWhiteSpace(input_reader_subscription_id.Text)))
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO [READER] (Name, Surname,  Date_of_Birth, Phone_number, Email, Subscription)" +
                                                            " VALUES (@Name, @Surname,  @Date_of_Birth, @Phone_number, @Email, @Subscription)", connection);
                        command.Parameters.AddWithValue("Name", input_reader_name.Text);
                        command.Parameters.AddWithValue("Surname", input_reader_surname.Text);
                        command.Parameters.AddWithValue("Date_of_Birth", input_reader_birthdate.Text);
                        command.Parameters.AddWithValue("Phone_number", input_reader_phonenumber.Text);
                        command.Parameters.AddWithValue("Email", input_reader_email.Text);
                        command.Parameters.AddWithValue("Subscription", input_reader_subscription_id.Text);
                        command.ExecuteNonQuery();
                        input_reader_name.Clear();
                        input_reader_surname.Clear();
                        input_reader_birthdate.Clear();
                        input_reader_phonenumber.Clear();
                        input_reader_email.Clear();
                        input_reader_subscription_id.Clear();
                    } 
                    else
                    {
                        MessageBox.Show("Поля 'Имя', 'Фамилия', 'Дата рождения', 'Телефонный номер', 'Email' и 'Абонемент' должны быть заполнены!");
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
            add_reader();
        }

        private void alter_reader()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    if (
                        (!string.IsNullOrEmpty(input_reader_id.Text)) && (!string.IsNullOrWhiteSpace(input_reader_id.Text)) && 
                        (!string.IsNullOrEmpty(input_alter_reader_name.Text)) && (!string.IsNullOrWhiteSpace(input_alter_reader_name.Text)) &&
                        (!string.IsNullOrEmpty(input_alter_reader_surname.Text)) && (!string.IsNullOrWhiteSpace(input_alter_reader_surname.Text)) &&
                        (!string.IsNullOrEmpty(input_alter_reader_fathersname.Text)) && (!string.IsNullOrWhiteSpace(input_alter_reader_fathersname.Text)) &&
                        (!string.IsNullOrEmpty(input_alter_reader_phonenumber.Text)) && (!string.IsNullOrWhiteSpace(input_alter_reader_phonenumber.Text)) &&
                        (!string.IsNullOrEmpty(input_alter_reader_email.Text)) && (!string.IsNullOrWhiteSpace(input_alter_reader_email.Text)) &&
                        (!string.IsNullOrEmpty(input_alter_reader_subscription_id.Text)) && (!string.IsNullOrWhiteSpace(input_alter_reader_subscription_id.Text)))
                    {
                        SqlCommand command = new SqlCommand("UPDATE [READER] SET [Name]=@Name, [Surname]=@Surname, [Fathers_name]=@Fathers_name, [Phone_number]=@Phone_number, [Email]=@Email, [Subscription]=@Subscription WHERE [id_reader]=@id_reader", connection);
                        command.Parameters.AddWithValue("id_reader", input_reader_id.Text);
                        command.Parameters.AddWithValue("Name", input_alter_reader_name.Text);
                        command.Parameters.AddWithValue("Surname", input_alter_reader_surname.Text);
                        command.Parameters.AddWithValue("Fathers_name", input_alter_reader_fathersname.Text);
                        command.Parameters.AddWithValue("Phone_number", input_alter_reader_phonenumber.Text);
                        command.Parameters.AddWithValue("Email", input_alter_reader_email.Text);
                        command.Parameters.AddWithValue("Subscription", input_alter_reader_subscription_id.Text);
                        command.ExecuteNonQuery();
                        input_reader_id.Clear();
                        input_alter_reader_name.Clear();
                        input_alter_reader_surname.Clear();
                        input_alter_reader_fathersname.Clear();
                        input_alter_reader_phonenumber.Clear();
                        input_alter_reader_email.Clear();
                        input_alter_reader_subscription_id.Clear();
                    }
                    else if (
                        (!string.IsNullOrEmpty(input_reader_id.Text)) && (!string.IsNullOrWhiteSpace(input_reader_id.Text)) &&
                        (!string.IsNullOrEmpty(input_alter_reader_name.Text)) && (!string.IsNullOrWhiteSpace(input_alter_reader_name.Text)) &&
                        (!string.IsNullOrEmpty(input_alter_reader_surname.Text)) && (!string.IsNullOrWhiteSpace(input_alter_reader_surname.Text)) &&
                        (string.IsNullOrEmpty(input_alter_reader_fathersname.Text)) || (string.IsNullOrWhiteSpace(input_alter_reader_fathersname.Text)) &&
                        (!string.IsNullOrEmpty(input_alter_reader_phonenumber.Text)) && (!string.IsNullOrWhiteSpace(input_alter_reader_phonenumber.Text)) &&
                        (!string.IsNullOrEmpty(input_alter_reader_email.Text)) && (!string.IsNullOrWhiteSpace(input_alter_reader_email.Text)) &&
                        (!string.IsNullOrEmpty(input_alter_reader_subscription_id.Text)) && (!string.IsNullOrWhiteSpace(input_alter_reader_subscription_id.Text)))
                    {
                        SqlCommand command = new SqlCommand("UPDATE [READER] SET [Name]=@Name, [Surname]=@Surname, [Phone_number]=@Phone_number, [Email]=@Email, [Subscription]=@Subscription WHERE [id_reader]=@id_reader", connection);
                        command.Parameters.AddWithValue("id_reader", input_reader_id.Text);
                        command.Parameters.AddWithValue("Name", input_alter_reader_name.Text);
                        command.Parameters.AddWithValue("Surname", input_alter_reader_surname.Text);
                        command.Parameters.AddWithValue("Phone_number", input_alter_reader_phonenumber.Text);
                        command.Parameters.AddWithValue("Email", input_alter_reader_email.Text);
                        command.Parameters.AddWithValue("Subscription", input_alter_reader_subscription_id.Text);
                        command.ExecuteNonQuery();
                        input_reader_id.Clear();
                        input_alter_reader_name.Clear();
                        input_alter_reader_surname.Clear();
                        input_alter_reader_phonenumber.Clear();
                        input_alter_reader_email.Clear();
                        input_alter_reader_subscription_id.Clear();
                    }
                    else 
                    {
                        MessageBox.Show("Все поля должны быть заполнены! Если у читателя нет отчества - оставить поле пустым. Если изменений нет - внесите старый вариант информации.");
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
            alter_reader();
        }
    }
}
