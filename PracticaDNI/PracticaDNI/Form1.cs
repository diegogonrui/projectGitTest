﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDNI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!DNITextBox.Text.Equals("")) { 
            int dni = Convert.ToInt32(DNITextBox.Text);
                char letter = functionDNI(dni);
                LaLetraLabel.Text = letter.ToString();
            }
        }

        private char functionDNI(int dni)
        {
            char letter = 'a';
            return letter;
        }
    }
}
