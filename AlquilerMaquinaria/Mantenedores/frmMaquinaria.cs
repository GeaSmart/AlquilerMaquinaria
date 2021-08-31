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
    public partial class frmMaquinaria : Form
    {
        private readonly int id;
        MAQUINARIA model = new MAQUINARIA();

        public frmMaquinaria()
        {
            InitializeComponent();
        }

        public frmMaquinaria(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var maquinaria = new MAQUINARIA
            {
                id = Convert.ToInt32(this.txtId.Text),
                equipo = this.txtEquipo.Text,
                numero_serie = this.txtNumeroSerie.Text,
                marca = this.txtMarca.Text,
                modelo = this.txtModelo.Text,
                estado = this.txtEstado.Text,
                fecha_compra = this.dtpFechaCompra.Value,
                ciclo_horas_mtto =Convert.ToInt32(this.nudCicloMtto.Value),
                horas_alquiler_defecto= Convert.ToInt32(this.nudHorasAlquiler.Value),
                precio_dia_defecto= this.nudPrecioDia.Value,
                observaciones = this.txtObservaciones.Text
            };
            var response = model.Guardar(maquinaria);

            MessageBox.Show(response.Message);

            if (response.Response)
                this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var response = model.Eliminar(Convert.ToInt32(this.txtId.Text));
            MessageBox.Show(response.Message);

            if (response.Response)
                this.Close();
        }

        private void frmMaquinaria_Load(object sender, EventArgs e)
        {
            this.btnEliminar.Visible = false;
            if (id > 0)
            {
                ResponseModel<MAQUINARIA> response = model.Obtener(id);
                var maquinariaDTO = Mapper.Map<MaquinariaDTO>(response.data);

                this.txtId.Text = maquinariaDTO.id.ToString();
                this.txtEquipo.Text = maquinariaDTO.equipo;
                this.txtNumeroSerie.Text = maquinariaDTO.numero_serie;
                this.txtMarca.Text = maquinariaDTO.marca;
                this.txtModelo.Text = maquinariaDTO.modelo;
                this.txtEstado.Text = maquinariaDTO.estado;
                this.dtpFechaCompra.Value = maquinariaDTO.fecha_compra;
                this.nudCicloMtto.Value = maquinariaDTO.ciclo_horas_mtto;
                this.nudHorasAlquiler.Value = maquinariaDTO.horas_alquiler_defecto;
                this.nudPrecioDia.Value = maquinariaDTO.precio_dia_defecto;
                this.txtObservaciones.Text = maquinariaDTO.observaciones;

                this.btnGuardar.Text = "Actualizar";
                this.btnEliminar.Visible = true;
            }
        }
    }
}
