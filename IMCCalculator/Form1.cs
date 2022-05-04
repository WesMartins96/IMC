﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMCCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double peso = double.Parse(txtPeso.Text, CultureInfo.InvariantCulture);
            double altura = double.Parse(txtAltura.Text, CultureInfo.InvariantCulture);
            IMC imc = new IMC();

            imc.Altura = altura;
            imc.Peso = peso;
            lblResultado.Text = imc.CalcIMC().ToString("F1", CultureInfo.InvariantCulture);
            txtAltura.Clear();
            txtPeso.Clear();

            double i = imc.CalcIMC();
            if (i < 24.9 )
            {
                MessageBox.Show("Normal");
            }
            else if (i < 29.9)
            {
                MessageBox.Show("Sobrepeso");
            }
            else if (i > 30.0 && i < 40.0)
            {
                MessageBox.Show("Obsidade");
            }
            else 
            {
                MessageBox.Show("Obsidade Grave");
            }
        }
    }
}
