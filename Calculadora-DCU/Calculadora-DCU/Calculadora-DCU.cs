using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_DCU
{
    public partial class Calculadora_DCU : Form
    {
        public Calculadora_DCU()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            accionSumar();
        }

        private void accionSumar()
        {
            int n1 = Convert.ToInt32(txtOpercaiones);
            int n2 = Convert.ToInt32(txtOpecaciones2);

            int resultado = Calculadora.Sumar(n1, n2);
            txtResultado.Text = resultado.ToString();
        }
    }
}
