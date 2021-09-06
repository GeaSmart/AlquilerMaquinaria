using AlquilerMaquinaria.Operaciones;
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
using System.Windows.Forms;

namespace AlquilerMaquinaria.Mantenedores
{
    public partial class frmListaClientes : Form
    {
        //AlquilerMaquinariaContext context = new AlquilerMaquinariaContext();
        CLIENTE model = new CLIENTE();
        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["id"].Value.ToString());
            frmCliente formulario = new frmCliente(id);
            formulario.ShowDialog();
            actualizarGrilla();
            //MessageBox.Show(id.ToString());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCliente formulario = new frmCliente();
            formulario.ShowDialog();
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            ResponseModel<List<CLIENTE>> response = model.Listar();
            this.dgvListado.DataSource = Mapper.Map<List<ListadoClienteDTO>>(response.data);
        }
    }
}
