using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        Form1 f1 = new Form1();
        public Form3()
        {
            InitializeComponent();
        }

        private void InfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа создана Валеев Д.А.");
        }

        private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f1.Show();
        }

        private void CloseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
