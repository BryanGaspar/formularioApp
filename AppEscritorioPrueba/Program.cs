using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorioPrueba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          
            //Numero decimal a Binario
          
            //Application.Run(new frmNumBinario());
                
            // Numero Binario a Decimal
           
            //Application.Run(new frmBinaNumero()); 
           
            //Numero Primo
             
            //Application.Run(new FrmNumeroPrimo());
            
            // Nombre y Edad
           
            //Application.Run(new frmNombreEdad());
           
            // Fecha de nacimiento años de vida y dias vividos
           
            Application.Run(new frmDatePickerEdad());
            
        }
    }
}
