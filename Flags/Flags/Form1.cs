﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void frenchFlag_Click(object sender, EventArgs e)
        {
            countryNameTextBox.Text = "France";
        }

        private void germanFlag_Click(object sender, EventArgs e)
        {
            countryNameTextBox.Text = "Germany";
        }

        private void swedishFlag_Click(object sender, EventArgs e)
        {
            countryNameTextBox.Text = "Sweden";
        }
    }
}
