using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOpBasicas02
{
    public partial class frmOpBasicas : Form
    {
        private int numero1;
        private int numero2;
        public frmOpBasicas()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var resultado = 0;
                var tipoOperacion = "";
                if (sumarRadioButton.Checked)
                {
                    tipoOperacion = "suma";
                    resultado = Calcular(numero1, numero2, TipoOperacion.Sumar);
                }
                else if (restarRadioButton.Checked)
                {
                    tipoOperacion = "resta";

                    resultado = Calcular(numero1, numero2, TipoOperacion.Restar);
                }
                else if (multiplicarRadioButton.Checked)
                {
                    tipoOperacion = "multiplicación";

                    resultado = Calcular(numero1, numero2, TipoOperacion.Multiplicar);
                }
                else
                {
                    tipoOperacion = "división";

                    resultado = Calcular(numero1, numero2, TipoOperacion.Dividir);
                }
                MessageBox.Show($"El resultado de la {tipoOperacion} es {resultado}");

                InicializarControles();
            }
        }

        private void InicializarControles()
        {
            numero1TextBox.Clear();
            numero2TextBox.Clear();
            numero1TextBox.Focus();
        }

        private int Calcular(int numero1, int numero2, TipoOperacion operacion)
        {
            int resultado = 0;
            switch (operacion)
            {
                case TipoOperacion.Sumar:
                    resultado = numero1 + numero2;
                    break;
                case TipoOperacion.Restar:
                    resultado = numero1 - numero2;
                    break;
                case TipoOperacion.Multiplicar:
                    resultado = numero1 * numero2;
                    break;
                case TipoOperacion.Dividir when numero2 != 0:
                    resultado = numero1 / numero2;
                    break;
            }
            return resultado;
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(numero1TextBox.Text, out numero1))
            {
                valido = false;
                errorProvider1.SetError(numero1TextBox, "Número mal ingresado");
            }
            if (!int.TryParse(numero2TextBox.Text, out numero2))
            {
                valido = false;
                errorProvider1.SetError(numero2TextBox, "Número mal ingresado");
            }
            return valido;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }
    }
}
