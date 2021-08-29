using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Model.Models;

namespace AlquilerMaquinaria.Mantenedores
{
    public partial class frmCliente : Form
    {
        //AlquilerMaquinariaContext context = new AlquilerMaquinariaContext();
        CLIENTE model = new CLIENTE();
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cliente = new CLIENTE
            {
                dni_ruc = this.txtDniRuc.Text,
                nombres_razonsocial = this.txtNombresRazon.Text,
                apellidos = this.txtApellidos.Text,
                telefono = this.txtTelefono.Text,
                celular = this.txtCelular.Text,
                direccion = this.txtDireccion.Text,
                observaciones = this.txtObservaciones.Text
            };
            var response = model.Guardar(cliente);

            MessageBox.Show(response.Message);            
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
