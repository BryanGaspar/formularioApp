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
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(int.Parse(txtNum.Text));
            lbRs.Visible = true;
            lbRs.Text =  "El Factorial de "+num+ " es: "+ factorial(num).ToString();
        }
        public static long factorial(int n)
        {
            if (n == 1)               // Aseguramos que termine (caso base)
                return 1;
            return n * factorial(n - 1);  // Si no es 1, sigue la recursión
        }
    }

}
