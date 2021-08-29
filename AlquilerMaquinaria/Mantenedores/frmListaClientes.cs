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
            this.dgvListado.DataSource = model.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResponseModel<List<CLIENTE>> resp = model.Listar();
            this.dgvListado.DataSource = Mapper.Map<List<ListadoClienteDTO>>(resp.data);
            MessageBox.Show(resp.Message);
        }
    }
}
