using AlquilerMaquinaria.Mantenedores;
using AutoMapper;
using Model.DTO;
using Model.Models;
using Model.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerMaquinaria.Operaciones
{
    public partial class frmAlquiler : Form
    {
        public frmAlquiler()
        {
            InitializeComponent();
        }

        private void frmAlquiler_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            frmCliente formulario = new frmCliente();
            formulario.ShowDialog();
        }

        private void cargarClientes()
        {
            //var context = new AlquilerMaquinariaContext();
            CLIENTE model = new CLIENTE();

            ResponseModel<List<CLIENTE>> response = model.Listar();
            this.cmbCliente.DataSource = Mapper.Map<List<ClienteDTO>>(response.data);

            this.cmbCliente.ValueMember = "id";
            this.cmbCliente.DisplayMember = "nombres_razonsocial";
        }

        List<DETALLE_CONTRATO> detalles = new List<DETALLE_CONTRATO>();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarMaquinaria form = new frmAgregarMaquinaria(ref detalles);
            form.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
