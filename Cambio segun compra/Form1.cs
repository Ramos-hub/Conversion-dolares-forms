using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cambio_segun_compra
{
    public partial class frmCambio : Form
    {
        double costo, dinero, total;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCosto.Clear();
            txtDinero.Clear();
            txtTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public frmCambio()
        {
            InitializeComponent();
            lblError.Text = string.Empty;
            txtTotal.ReadOnly = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            costo = double.Parse(txtCosto.Text);
            dinero = double.Parse(txtDinero.Text);
            txtDinero.ReadOnly = true;
            txtCosto.ReadOnly = true;
           if (dinero < costo)
            {
                lblError.Text = "Aun te falta dinero, por favor entrega la cantida requerida";
            }
           else
            {
                total = dinero - costo;
                txtTotal.Text = total.ToString("N2");
            }
        }
    }
}
