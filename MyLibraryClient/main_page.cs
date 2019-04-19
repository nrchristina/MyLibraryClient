using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MyLibraryClient
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }
        
        books books = new books();
        readers readers = new readers();
        output output = new output();
        fine fine = new fine();
        subscription subscription = new subscription();
        authors authors = new authors();
        genres genres = new genres();
        parts parts = new parts();
        publishers publishers = new publishers();
        archive archive = new archive();
        start start = new start();

        private void books_button_Click(object sender, EventArgs e)
        {
             if (books.IsDisposed)
                 books = new books();
             if (!books.Visible)
                 books.Show();
             if (books.WindowState == FormWindowState.Minimized)
                 books.WindowState = FormWindowState.Normal;
             else
                 books.Activate(); 
        }

        private void readers_button_Click(object sender, EventArgs e)
        {
            if (readers.IsDisposed)
                readers = new readers();
            if (!readers.Visible)
                readers.Show();
            if (readers.WindowState == FormWindowState.Minimized)
                readers.WindowState = FormWindowState.Normal;
            else
                readers.Activate();
        }

        private void output_button_Click(object sender, EventArgs e)
        {
            if (output.IsDisposed)
                output = new output();
            if (!output.Visible)
                output.Show();
            if (output.WindowState == FormWindowState.Minimized)
                output.WindowState = FormWindowState.Normal;
            else
                output.Activate();
        }

        private void fines_button_Click(object sender, EventArgs e)
        {
            if (fine.IsDisposed)
                fine = new fine();
            if (!fine.Visible)
                fine.Show();
            if (fine.WindowState == FormWindowState.Minimized)
                fine.WindowState = FormWindowState.Normal;
            else
               fine.Activate();
        }

        private void subcrciption_button_Click(object sender, EventArgs e)
        {
            if (subscription.IsDisposed)
                subscription = new subscription();
            if (!subscription.Visible)
                subscription.Show();
            if (subscription.WindowState == FormWindowState.Minimized)
                subscription.WindowState = FormWindowState.Normal;
            else
                subscription.Activate();
        }

        private void authors_button_Click(object sender, EventArgs e)
        {
            if (authors.IsDisposed)
                authors=new authors();
            if (!authors.Visible)
                authors.Show();
            if (authors.WindowState == FormWindowState.Minimized)
                authors.WindowState = FormWindowState.Normal;
            else
                authors.Activate();
        }

        private void genres_button_Click(object sender, EventArgs e)
        {
            if (genres.IsDisposed)
                genres = new genres();
            if (!genres.Visible)
                genres.Show();
            if (genres.WindowState == FormWindowState.Minimized)
                genres.WindowState = FormWindowState.Normal;
            else
                genres.Activate();
        }

        private void parts_button_Click(object sender, EventArgs e)
        {
            if (parts.IsDisposed)
                parts = new parts();
            if (!parts.Visible)
                parts.Show();
            if (parts.WindowState == FormWindowState.Minimized)
                parts.WindowState = FormWindowState.Normal;
            else
                parts.Activate();
        }

        private void publishers_button_Click(object sender, EventArgs e)
        {
            if (publishers.IsDisposed)
                publishers = new publishers();
            if (!publishers.Visible)
                publishers.Show();
            if (publishers.WindowState == FormWindowState.Minimized)
                publishers.WindowState = FormWindowState.Normal;
            else
                publishers.Activate();
        }

        private void archive_button_Click(object sender, EventArgs e)
        {
            if (archive.IsDisposed)
                archive = new archive();
            if (!archive.Visible)
                archive.Show();
            if (archive.WindowState == FormWindowState.Minimized)
                archive.WindowState = FormWindowState.Normal;
            else
                archive.Activate();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Hide();
            books.Close();
            readers.Close();
            output.Close();
            fine.Close();
            subscription.Close();
            authors.Close();
            genres.Close();
            parts.Close();
            publishers.Close();
            archive.Close();
        }

        private void main_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            books.Close();
            readers.Close();
            output.Close();
            fine.Close();
            subscription.Close();
            authors.Close();
            genres.Close();
            parts.Close();
            publishers.Close();
            archive.Close();
        }
    }
}
