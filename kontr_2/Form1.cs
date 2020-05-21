using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kontr_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.Owner = this;
            //this.Show();
            Form2 f2 = new Form2();
            f2.BackgroundImage = pictureBox1.BackgroundImage;
            f2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            CheckEmail check = new CheckEmail(name, email);
            if (check.Check() == false)
                button1.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[2];
        }
    }
}
