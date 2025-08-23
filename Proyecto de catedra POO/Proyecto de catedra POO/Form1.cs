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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistroProdu = new FormRegistro();
            formRegistroProdu.Show();
            this.Hide();
        }

        private void btnlista_Click(object sender, EventArgs e)
        {
                FormListado formListado = new FormListado();
                formListado.Show();
                this.Close();
        }

        private void btncajero_Click(object sender, EventArgs e)
        {
           FormCajero formCajero = new FormCajero();
            formCajero.Show();
            this.Close();
        }
    }
}
