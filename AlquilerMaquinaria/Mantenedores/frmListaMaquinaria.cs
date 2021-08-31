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

namespace AlquilerMaquinaria.Mantenedores
{
    public partial class frmListaMaquinaria : Form
    {

        MAQUINARIA model = new MAQUINARIA();
        public frmListaMaquinaria()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMaquinaria formulario = new frmMaquinaria();
            formulario.ShowDialog();
            actualizarGrilla();
        }

        private void frmListaMaquinaria_Load(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            ResponseModel<List<MAQUINARIA>> response = model.Listar();
            this.dgvListado.DataSource = Mapper.Map<List<ListadoMaquinariaDTO>>(response.data);
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["id"].Value.ToString());
            frmMaquinaria formulario = new frmMaquinaria(id);
            formulario.ShowDialog();
            actualizarGrilla();
        }
    }
}
