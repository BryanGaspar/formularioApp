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
    public partial class frmDatePickerEdad : Form
    {
        public frmDatePickerEdad()
        {
            InitializeComponent();
        }

        private void frmDatePickerEdad_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;
            int edadAnos = fechaActual.Year - dateTimePicker1.Value.Year;
            int edadDias = ((fechaActual.Year - dateTimePicker1.Value.Year) * 365) + ((fechaActual.Month - dateTimePicker1.Value.Month) * 31)
                + fechaActual.Day - dateTimePicker1.Value.Day;
            txtanos.Text = edadAnos.ToString()+ " Años de Vida";
            txtDias.Text = edadDias.ToString()+ " Días Vividos";
       

        }
    }
}
