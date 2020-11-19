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
    public partial class frmBinaNumero : Form
    {
        public frmBinaNumero()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double residuo = 0;
            double suma = 0;
            if (checkBox8.Checked == true)
            {
                residuo = Math.Pow(2, 0);
                suma += residuo;
            }
            if (checkBox7.Checked == true)
            {
                residuo = Math.Pow(2, 1);
                suma += residuo;
            }
            if (checkBox6.Checked == true)
            {
                residuo = Math.Pow(2, 2);
                suma += residuo;
            }
            if (checkBox5.Checked == true)
            {
                residuo = Math.Pow(2, 3);
                suma += residuo;
            }
            if (checkBox4.Checked == true)
            {
                residuo = Math.Pow(2, 4);
                suma += residuo;
            }
            if (checkBox3.Checked == true)
            {
                residuo = Math.Pow(2, 5);
                suma += residuo;
            }
            if (checkBox2.Checked == true)
            {
                residuo = Math.Pow(2, 6);
                suma += residuo;
            }
            if (checkBox1.Checked == true)
            {
                residuo = Math.Pow(2, 7);
                suma += residuo;
            }
            txtNum.Text = suma.ToString();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
