using System;
using System.Windows.Forms;

namespace _6_lab
{
    public partial class Form2 : Form
    {
        public int line;
        public User user;
        public Form2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Visible = false;
            //if (textBox1.Text == textBox2.Text) button1.Visible = true;
            user.ChangePassword(textBox1.Text, line);
            this.Close();
        }
    }
}
