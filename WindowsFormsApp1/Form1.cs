﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }
        private void SetButtonText()
        {
            button1.Text =
            "Location = " + Location + "\n" +
            "Left/Right/Width =" + Left + ", " + Right + ", " + Width + "\n" +
            "Top/Bottom/Height = " + Top + ", " + Bottom + ", " + Height;
            /*button1.Text = "Form.FormBorderStyle = " + FormBorderStyle.ToString() + "\n" +
            "Form.Size = " + Size.ToString() + "\n" +
            "Form.ClientSize = " + ClientSize.ToString();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetButtonText();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.SizableToolWindow)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle++;
            SetButtonText();

        }
        private void Form1_Move(object sender, EventArgs e)
        {
            SetButtonText();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetButtonText();

        }
    }
}
