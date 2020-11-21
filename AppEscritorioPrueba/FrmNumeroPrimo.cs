using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorioPrueba
{
    public partial class FrmNumeroPrimo : Form
    {
        public FrmNumeroPrimo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNum.Text, out double SoloNum))
            {
                MessageBox.Show("Por favor ingresa solo valores numéricos....", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtNum.Clear();
                this.txtNum.Focus();
                return;
            }
            int numero = int.Parse(txtNum.Text);
            determinarPrimo(numero);
        }
        void determinarPrimo(int numero)
        {
            int cont = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    cont++;
                }
            }

            if (cont == 2)
            {
                label2.Text = Convert.ToString(numero + " es primo");
                label2.Visible = true;
            }
            else
            {
                label2.Text = Convert.ToString(numero + " no es primo");
                label2.Visible = true;
            }
        }
    }
}
