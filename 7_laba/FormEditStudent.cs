﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_laba
{
    public partial class FormEditStudent : Form
    {
        public demoEntities1 db = new demoEntities1();
        students item;

        public FormEditStudent(students stud)
        {
            item = stud;
            InitializeComponent();

            var group_for_list = (from g in db.groups
                                  select g.name_group).Distinct();

            foreach (string it in group_for_list)
            {
                comboBox1.Items.Add(it);
            }

            textBox1.Text = item.surname.ToString();
            textBox2.Text = item.name.ToString();

            var query = (from g in db.groups
                         where g.code_group == item.code_group
                         select g.name_group).ToList();

            comboBox1.SelectedItem = query[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = ((Form1)Owner).db.students.SingleOrDefault(w => w.code_stud == item.code_stud);
            result.surname = textBox1.Text.ToString().Replace(" ", "");
            result.name = textBox2.Text.ToString().Replace(" ", "");
            var query = (from g in db.groups
                         where g.name_group == comboBox1.SelectedItem.ToString()
                         select g.code_group).ToList();
            result.code_group = query[0];

            ((Form1)Owner).studentsheet = ((Form1)Owner).db.students.OrderBy(o => o.code_stud).ToList();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
