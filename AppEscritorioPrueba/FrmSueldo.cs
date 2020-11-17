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
    public partial class FrmSueldo : Form
    {
        public FrmSueldo()
        {
            InitializeComponent();
        }

        private void txtTotalEgre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerrar el formulario
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

          

            // validaciones
            if (this.txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por Favor Debes Ingresar El Nombre...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtNombre.Focus();
                return;//Abandonar

            }
            else if (this.txtHorasTrab.Text.Length == 0)
            {
                MessageBox.Show("Por Favor Rellene El Campo: Total de Horas Trabajadas...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtHorasTrab.Focus();
                return;//Abandonar
            }
            else if (this.txtValorHora.Text.Length == 0)
            {
                MessageBox.Show("Por Favor Rellene El Campo: Valor por Hora...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtValorHora.Focus();
                return;//Abandonar
            }
            else if (this.txtBono.Text.Length == 0)
            {
                MessageBox.Show("Por Favor Rellene El Campo: Bono de responsabilidad...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtBono.Focus();
                return;//Abandonar
            }
            else if (this.txtAsoTrab.Text.Length == 0)
            {
                MessageBox.Show("Por Favor Rellene El Campo: Asociacion de Trabajadores...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtAsoTrab.Focus();
                return;//Abandonar
            }
            else if (this.txtBar.Text.Length == 0)
            {
                MessageBox.Show("Por Favor Debes Rellene El Campo: Bar...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtBar.Focus();
                return;//Abandonar
            }
            else if (this.txtCuentaPag.Text.Length == 0)
            {
                MessageBox.Show("Por Favor Rellene el Campo: Cuentas Por Pagar...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtCuentaPag.Focus();
                return;//Abandonar
            }
            //Tarea 
            //1. validar ingreso de todos los cuadros de texto
            //2. validar que el dato ingresado sea numerico no usar try .. catch
            //3. 
            //Sumar Ingresos
            double horasTrab = double.Parse(this.txtHorasTrab.Text);
            double valorHora = double.Parse(this.txtValorHora.Text);
            double bono = double.Parse(this.txtBono.Text);
            double totIng = (horasTrab * valorHora) + bono;

            //Mostrar en el textBox
            this.txtTotalIng.Text = totIng.ToString();
            //Sumar Egresos
            double asoTrab = double.Parse(this.txtAsoTrab.Text);
            double bar = double.Parse(this.txtBar.Text);
            double CuentasPagar = double.Parse(this.txtCuentaPag.Text);
            double totEgr = asoTrab+ bar + CuentasPagar;

            this.txtTotalEgre.Text = totEgr.ToString();
            double liquidoRecibir = totIng - totEgr;
            lblResultado.Text = "Estimado " + this.txtNombre.Text +
                ", tu sueldo es: " + liquidoRecibir.ToString();
        }

        private void txtHorasTrab_TextChanged(object sender, EventArgs e)
        {

        }

        //Validacion: Solo numeros
        private void txtHorasTrab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValorHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAsoTrab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCuentaPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //Validacion: Solo letras
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
     
    }
}
