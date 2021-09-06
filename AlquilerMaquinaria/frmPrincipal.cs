using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerMaquinaria
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void verListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.frmListaClientes form = new Mantenedores.frmListaClientes();
            form.MdiParent = this;
            form.Show();
        }

        private void crearNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.frmCliente form = new Mantenedores.frmCliente();
            form.MdiParent = this;
            form.Show();
        }

        private void verListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.frmListaMaquinaria form = new Mantenedores.frmListaMaquinaria();
            form.MdiParent = this;
            form.Show();
        }

        private void crearMaquinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.frmMaquinaria form = new Mantenedores.frmMaquinaria();
            form.MdiParent = this;
            form.Show();
        }

        private void generarNuevoContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operaciones.frmAlquiler form = new Operaciones.frmAlquiler();
            form.MdiParent = this;
            form.Show();
        }
    }
}
