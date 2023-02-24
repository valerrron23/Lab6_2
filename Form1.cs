﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_2
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // здесь ваш код
            int counter = 0; // количество слагаемых
            double sum = 0; // сумма
            double summand = 0.0; // слагаемое
            double x;
            double precision;
            bool f = false;

            if (double.TryParse(txtPrecision.Text, out precision)) 
            {
                f = true;
                while (f && Math.Abs(summand) > precision);
            }
            do
            {
                counter++;
                if (double.TryParse(txtX.Text, out x))
                {
                    summand = double.Parse(txtX.Text) / counter;
                }
                sum += summand;
            }
            while (Math.Abs(summand) > double.Parse(txtPrecision.Text));
            lblResult.Text = "сумма = " + sum + ", количество = " + counter;
            if (f)
            {
                lblResult.Text = "сумма = " + sum + ", количество = " + counter;
            }
            else
            {
                MessageBox.Show("введите числовое значение! ");
            }


        }
    }
}
