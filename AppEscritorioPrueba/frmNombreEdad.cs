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
    public partial class frmNombreEdad : Form
    {
        public frmNombreEdad()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtEdad.Text, out double SoloNum))
            {
                MessageBox.Show("Por favor ingresa solo valores numéricos en el campo edad....", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtEdad.Clear();
                this.txtEdad.Focus();
                return;
            }
            int edad = int.Parse(txtEdad.Text);
            //condicioneales
            if (!(edad >= 15 && edad <= 80))
            {
                MessageBox.Show(txtNombre.Text + ", Usted no esta en el rango establecido que comprenden edades de entre 15....80 años", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (edad >= 15 && edad <= 17)
            {

                txtRes.Text = txtNombre.Text + ", Eres menor de edad";
                txtRes.Visible = true;
            }

            if (edad >= 18 && edad <= 25)
            {

                txtRes.Text = txtNombre.Text + ", Puedes votar en las elecciones 2021";
                txtRes.Visible = true;
            }
            if (edad >= 26 && edad <= 30)
            {

                txtRes.Text = txtNombre.Text + ", Ya debes casarte";
                txtRes.Visible = true;
            }
        }//fin btn Calcular
        void determinarEdad(int edad)
        {
          
       
             
          
                if (edad >= 31 && edad <= 50)
                {

                    txtRes.Text = txtNombre.Text + ", Trabaja, duerme y disfruta";
                    txtRes.Visible = true;
                }
                if (edad > 50 )
                {

                    txtRes.Text = txtNombre.Text + ", Ya casi llegas a la tercera edad";
                    txtRes.Visible = true;
                }



        }//fin Determinar Edad
    }
}
