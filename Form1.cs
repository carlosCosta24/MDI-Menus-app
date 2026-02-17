using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findClintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FindClient = new Form2();
            FindClient.ShowDialog();

        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Client has been Added");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your are logged out!");
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SecondForm = new Form2();
            SecondForm.ShowDialog();
        }
    }
}
