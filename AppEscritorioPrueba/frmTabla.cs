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
    public partial class frmTabla : Form
    {
        public frmTabla()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int mult = 0;
            int tabla = int.Parse(txtTabla.Text);
            listBox1.Items.Clear();
            for (int x = 1; x <= 12; x++)
            {
                mult = tabla * x;

                listBox1.Items.Add("La multiplicacion de: "+ tabla.ToString()+ " x "+ x.ToString()+ " = " +mult.ToString());
            
            
            }
        }
    }
}
