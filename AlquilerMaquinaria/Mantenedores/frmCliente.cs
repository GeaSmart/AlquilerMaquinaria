using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoMapper;
using Model;
using Model.DTO;
using Model.Models;
using Model.Shared;

namespace AlquilerMaquinaria.Mantenedores
{
    public partial class frmCliente : Form
    {
        private readonly int id;

        //AlquilerMaquinariaContext context = new AlquilerMaquinariaContext();
        CLIENTE model = new CLIENTE();
        public frmCliente()
        {
            InitializeComponent();
        }
        public frmCliente(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cliente = new CLIENTE
            {
                id=Convert.ToInt32(this.txtId.Text),
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

            if (response.Response)
                this.Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                ResponseModel<CLIENTE> response = model.Obtener(id);
                var clienteDTO = Mapper.Map<ClienteDTO>(response.data);

                this.txtId.Text = clienteDTO.id.ToString();
                this.txtDniRuc.Text = clienteDTO.dni_ruc;
                this.txtNombresRazon.Text = clienteDTO.nombres_razonsocial;
                this.txtApellidos.Text = clienteDTO.apellidos;
                this.txtTelefono.Text = clienteDTO.telefono;
                this.txtCelular.Text = clienteDTO.celular;
                this.txtDireccion.Text = clienteDTO.direccion;
                this.txtObservaciones.Text = clienteDTO.observaciones;

                this.btnGuardar.Text = "Actualizar";
            }
        }
    }
}
