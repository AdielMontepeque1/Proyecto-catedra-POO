using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_catedra_POO
{
    public partial class FormCajero : Form
    {
        public FormCajero()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            FormMain formPrincipal = new FormMain();
            formPrincipal.Show();
            this.Close();
        }
    }
}
