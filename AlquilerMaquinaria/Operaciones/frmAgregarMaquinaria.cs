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
    public partial class frmAgregarMaquinaria : Form
    {
        private readonly List<DETALLE_CONTRATO> detalles;

        //public frmAgregarMaquinaria()
        //{
        //    InitializeComponent();
        //}

        public frmAgregarMaquinaria(ref List<DETALLE_CONTRATO> detalles)
        {
            InitializeComponent();
            this.detalles = detalles;
        }

        private void frmAgregarMaquinaria_Load(object sender, EventArgs e)
        {
            cargarMaquinaria();
        }

        private void cargarMaquinaria()
        {            
            MAQUINARIA model = new MAQUINARIA();

            ResponseModel<List<MAQUINARIA>> response = model.Listar();
            this.cmbMaquinaria.DataSource = Mapper.Map<List<MaquinariaDTO>>(response.data);

            this.cmbMaquinaria.ValueMember = "id";
            this.cmbMaquinaria.DisplayMember = "equipo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            var detalle = new DETALLE_CONTRATO();
            detalle.idMaquinaria = Convert.ToInt32(this.cmbMaquinaria.SelectedValue);
            detalle.numero_dias = Convert.ToInt32(this.nudNumeroDias.Value);
            detalle.horas_uso_total_mtto = Convert.ToInt32(this.nudHorasUsoMtto.Value);
            detalle.monto_precio_dia = this.nudPrecioDia.Value;
            detalle.monto_subtotal = this.nudSubtotal.Value;
            detalle.monto_descuento = this.nudDescuento.Value;

            detalles.Add(detalle);

        }
    }
}
