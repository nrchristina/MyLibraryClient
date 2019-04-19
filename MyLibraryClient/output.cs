using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

private void tabControl1_Click(object sender, EventArgs e)
        {
            input_fine.Hide();
            fine_id.Hide();

        }

        private void add_fine_button_Click(object sender, EventArgs e)
        {
            input_fine.Show();
            fine_id.Show();
            add_fine_button.Hide();
        }
    }
}
