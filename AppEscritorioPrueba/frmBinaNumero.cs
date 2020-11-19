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
            double res = 0;
            double suma = 0;
            if (checkBox8.Checked == true)
            {
                res = Math.Pow(2, 0);
                suma += res;
            }
            if (checkBox7.Checked == true)
            {
                res = Math.Pow(2, 1);
                suma += res;
            }
            if (checkBox6.Checked == true)
            {
                res = Math.Pow(2, 2);
                suma += res;
            }
            if (checkBox5.Checked == true)
            {
                res = Math.Pow(2, 3);
                suma += res;
            }
            if (checkBox4.Checked == true)
            {
                res = Math.Pow(2, 4);
                suma += res;
            }
            if (checkBox3.Checked == true)
            {
                res = Math.Pow(2, 5);
                suma += res;
            }
            if (checkBox2.Checked == true)
            {
                res = Math.Pow(2, 6);
                suma += res;
            }
            if (checkBox1.Checked == true)
            {
                res = Math.Pow(2, 7);
                suma += res;
            }
            txtNum.Text = suma.ToString();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
