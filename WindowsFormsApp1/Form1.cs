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
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" || textBox2.Text == "1234")
            {
                f2.Show();
                
            }
            else
            {
                MessageBox.Show("Неправильно введены логин и/или пароль");
            }
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
