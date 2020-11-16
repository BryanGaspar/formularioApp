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
            if(this.txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por Favor Debes Ingresar El Nombre...");
                this.txtNombre.Focus();
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
        
    }
}
