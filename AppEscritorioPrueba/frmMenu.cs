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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSueldo_Click(object sender, EventArgs e)
        {
            // Abrir formulario que calcule el sueldo
            FrmSueldo frm1 = new FrmSueldo();
            frm1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            // Abrir formulario entero a binario
            frmNumBinario frm2 = new frmNumBinario();
            frm2.Show();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // Abrir formulario binario a numero decimal
            frmBinaNumero frm3 = new frmBinaNumero();
            frm3.Show();

        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            // Abrir formulario Numeros Primos
            FrmNumeroPrimo frm4 = new FrmNumeroPrimo();
            frm4.Show();
        }

        private void btnEdadNom_Click(object sender, EventArgs e)
        {
            frmNombreEdad frm5 = new frmNombreEdad();
            frm5.Show();
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            frmDatePickerEdad frm6 = new frmDatePickerEdad();
            frm6.Show();
        }

      
    }
}
