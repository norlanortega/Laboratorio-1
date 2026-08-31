
using System;
using System.Windows.Forms;

namespace Pract8_EstructuraIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblOperacion_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbSumar_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton opcion = (RadioButton)sender;

            if (!opcion.Checked)
                return;

            if (rdbSumar.Checked)
                lblOperacion.Text = "+";
            else if (rdbRestar.Checked)
                lblOperacion.Text = "-";
            else if (rdbMulti.Checked)
                lblOperacion.Text = "*";
            else if (rdbDivision.Checked)
                lblOperacion.Text = "/";

            if (!decimal.TryParse(textBox1.Text, out decimal numero1))
            {
                txtResult.Text = "";
                MessageBox.Show("Falta el primer valor.");
                return;
            }

            if (!decimal.TryParse(textBox2.Text, out decimal numero2))
            {
                txtResult.Text = "";
                MessageBox.Show("Falta el segundo valor.");
                return;
            }

            decimal resultado = 0;

            if (rdbSumar.Checked)
                resultado = numero1 + numero2;
            else if (rdbRestar.Checked)
                resultado = numero1 - numero2;
            else if (rdbMulti.Checked)
                resultado = numero1 * numero2;
            else if (rdbDivision.Checked)
            {
                if (numero2 == 0)
                {
                    txtResult.Text = "";
                    MessageBox.Show("No se puede dividir entre cero.");
                    return;
                }

                resultado = numero1 / numero2;
            }

            txtResult.Text = resultado.ToString();
        }

        private void rdbRestar_CheckedChanged(object sender, EventArgs e)
        {
            rdbSumar_CheckedChanged(sender, e);
        }

        private void rdbMulti_CheckedChanged(object sender, EventArgs e)
        {
            rdbSumar_CheckedChanged(sender, e);
        }

        private void rdbDivision_CheckedChanged(object sender, EventArgs e)
        {
            rdbSumar_CheckedChanged(sender, e);
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
