using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico3NumII
{
    public partial class txtBoxUs : Form
    {
        public txtBoxUs()
        {
            InitializeComponent();
        }

        private void ButtCerrar_Click (object sender, EventArgs e)
        {
            var eleccion = DialogResult;
            for (int i = 0; i < 1; i++)
            {
                eleccion = MessageBox.Show("Desea continuar? Presione SI para salir y NO para continuar" + i,
                    "Salir", MessageBoxButtons.YesNo);
            }

            if (eleccion == DialogResult.Yes)
            {
                Close();
            }

            
        }

        private void ButtEntrar_Click(object sender, EventArgs e)
        {
            string Var_Usuario = textBoxUsuario.Text;
            string Var_Contraseña = txtBoxContra.Text;
            

            if (Var_Usuario != "Mariano" & Convert.ToInt32 (Var_Contraseña) < 1000)
            {
                MessageBox.Show("Acceso Permitido");


            
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");  
            }
        }
    }
}
