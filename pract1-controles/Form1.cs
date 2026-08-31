
using System;
using System.Windows.Forms;

namespace pract1_controles
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

        private void lblDay_Click(object sender, EventArgs e)
        {

        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtDay.Text) ||
                string.IsNullOrWhiteSpace(txtMonth.Text) ||
                string.IsNullOrWhiteSpace(txtYear.Text))
            {
                MessageBox.Show(
                    "Debe llenar todos los campos.",
                    "Error de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // Verificar que sean números
            if (!int.TryParse(txtDay.Text, out int dia) ||
                !int.TryParse(txtMonth.Text, out int mes) ||
                !int.TryParse(txtYear.Text, out int anio))
            {
                MessageBox.Show(
                    "Ingrese valores numéricos válidos.",
                    "Error de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // Verificar que la fecha sea válida
            try
            {
                DateTime fecha = new DateTime(anio, mes, dia);

                lblThedateIs.Text = "La fecha es: " +
                                    string.Join("/", txtDay.Text, txtMonth.Text, txtYear.Text);
            }
            catch
            {
                MessageBox.Show(
                    "La fecha ingresada no es válida.",
                    "Error de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
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

        private void lblThedateIs_Click(object sender, EventArgs e)
        {

        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

