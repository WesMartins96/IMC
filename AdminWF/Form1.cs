using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminWF
{
    public partial class btnCalcQ : Form
    {
        public btnCalcQ()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double b = double.Parse(txtBase.Text);
            double a = double.Parse(txtAltura.Text);
            Triangulo triangulo = new Triangulo();
            triangulo.Altura = a;
            triangulo.Base = b;
            lblTotal.Text = triangulo.CalcTriangulo().ToString("F2", CultureInfo.InvariantCulture);
            txtAltura.Clear();
            txtBase.Clear();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ladoA = int.Parse(txtLadoA.Text);
            double ladoB = int.Parse(txtLadoB.Text);
            Quadrado q = new Quadrado();
            q.LadoA = ladoA;
            q.LadoB = ladoB;
            lblCalcularQuadrado.Text = q.CalcQuadrado().ToString("F2", CultureInfo.InvariantCulture);
            txtLadoA.Clear();
            txtLadoB.Clear();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
