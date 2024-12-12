using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_Primera_Vez.Presentacion
{
    public partial class CUUsuario : UserControl
    {
        public CUUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personal.Frmpersonal frmpersonal = new Personal.Frmpersonal("n");
            frmpersonal.Text = "Nuevo Ingreso de Personal";
            frmpersonal.ShowDialog();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
