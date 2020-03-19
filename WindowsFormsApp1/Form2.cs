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
    public partial class Form2 : Form
    {
        //Form3 f3 = new Form3();
        //Form2 f2 = new Form2();
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
            Show(new Form3());
        }



        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //pictureBox1 = Image.FromFile(Properties.Resources._113264_krasota_rastsvet_tsvetok_sad_roz_uhod_za_licom_3840x2160);
    }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            BackgroundImage = pictureBox1.Image;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(Properties.Resources._113523_nebo_vihr_lazurnyj_prostranstvo_kosmos_2560x1600);
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(Properties.Resources._18e576a5623628b6f4975c09a2e39921);
        }
    }
}
