﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i, j;
            if (textBox1.Text == "") i = 0;
            else i = double.Parse(textBox1.Text);
            if (textBox2.Text == "") j = 0;
            else j = double.Parse(textBox2.Text);
            //textBox1.Text = "";
            //textBox2.Text = "";
            textBox3.Text = Convert.ToString(i+j);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double i, j;
            if (textBox1.Text == "") i = 0;
            else i = double.Parse(textBox1.Text);
            if (textBox2.Text == "") j = 0;
            else j = double.Parse(textBox2.Text);
            //textBox1.Text = "";
            //textBox2.Text = "";
            textBox3.Text = Convert.ToString(i - j);
        }
    }
}
