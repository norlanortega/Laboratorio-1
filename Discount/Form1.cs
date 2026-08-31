
using System;
using System.Windows.Forms;

namespace Discount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblValorVenta_Click(object sender, EventArgs e)
        {

        }

        private void txtValorV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal venta;
            decimal porcentaje;
            decimal descuento;
            decimal total;

            if (!decimal.TryParse(txtValorV.Text, out venta))
            {
                MessageBox.Show("Ingrese un valor de ventas válido.");
                return;
            }

            if (venta >= 500)
            {
                porcentaje = 0.30m;
            }
            else if (venta >= 300)
            {
                porcentaje = 0.20m;
            }
            else if (venta >= 100)
            {
                porcentaje = 0.10m;
            }
            else
            {
                porcentaje = 0;
            }

            descuento = venta * porcentaje;
            total = venta - descuento;

            txtVentaFinal.Text = total.ToString();
            txtDescuentoP.Text = (porcentaje * 100).ToString() + "%";
            txtDescuento.Text = descuento.ToString();
        }

        private void lblDescuento_Click(object sender, EventArgs e)
        {

        }

        private void lblDescuentoP_Click(object sender, EventArgs e)
        {

        }

        private void lblVentaFinal_Click(object sender, EventArgs e)
        {

        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescuentoP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVentaFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorV.Text = "";
            txtDescuento.Text = "";
            txtDescuentoP.Text = "";
            txtVentaFinal.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrará la ventana");

            DialogResult = MessageBox.Show(
                "¿Desea cerrar?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (DialogResult == DialogResult.No)
                return;

            MessageBox.Show("Cerrando");

            Close();
        }
    }
}

