using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora2
{
    public partial class Form1 : Form
    {

        wsCalculadora.CalculatorSoapClient ws = new wsCalculadora.CalculatorSoapClient();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {  lblResultado.Text=ws.Add(Convert.ToInt32(txtCantidad1.Text), Convert.ToInt32(txtCantidad2.Text)).ToString();

            // lblResultado.Text = (Convert.ToInt32(txtCantidad1.Text) +  Convert.ToInt32(txtCantidad2.Text)).ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            lblResultado.Text = ws.Subtract(Convert.ToInt32(txtCantidad1.Text), Convert.ToInt32(txtCantidad2.Text)).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = ws.Divide(Convert.ToInt32(txtCantidad1.Text), Convert.ToInt32(txtCantidad2.Text)).ToString();
        }

        private void btnMutiplicar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = ws.Multiply(Convert.ToInt32(txtCantidad1.Text), Convert.ToInt32(txtCantidad2.Text)).ToString();
        }
    }
}
