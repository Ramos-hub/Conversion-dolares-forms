using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversion_de_dolares_a_pesos_mexicanos
{
    public partial class frmConversion : Form
    {
        double dolares, resultado;
        public frmConversion()
        {
            InitializeComponent();
            lblError.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDolares.Clear();
            txtResultado.Clear();
            lblError.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConver_Click(object sender, EventArgs e)
        {
            
            dolares = double.Parse(txtDolares.Text);
            if (dolares < 0)
            {
                lblError.Text = "Ingrese valores positivos";
            }
            else
            {
                resultado = dolares * 18;
                txtResultado.Text = resultado.ToString("N2");
            }
        }

    }
}
