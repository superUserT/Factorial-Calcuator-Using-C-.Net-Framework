﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int factorial = 1;
            int number;
            int i;
            

            number = Convert.ToInt32(txtNumber.Text);
           
            for     (i = 1; i <= number; i++)
            {
                factorial = factorial * i;
                txtFactorial.Text = factorial.ToString();
               

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
