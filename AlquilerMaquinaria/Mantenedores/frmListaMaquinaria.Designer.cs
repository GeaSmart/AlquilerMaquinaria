
namespace AlquilerMaquinaria.Mantenedores
{
    partial class frmListaMaquinaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_completo_razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 41);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Crear nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tipo_documento,
            this.numero_documento,
            this.nombre_completo_razon_social,
            this.celular,
            this.direccion});
            this.dgvListado.Location = new System.Drawing.Point(12, 59);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.RowTemplate.Height = 24;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(1141, 617);
            this.dgvListado.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // tipo_documento
            // 
            this.tipo_documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tipo_documento.DataPropertyName = "tipo_documento";
            this.tipo_documento.HeaderText = "Tipo Documento";
            this.tipo_documento.MinimumWidth = 6;
            this.tipo_documento.Name = "tipo_documento";
            this.tipo_documento.ReadOnly = true;
            this.tipo_documento.Width = 129;
            // 
            // numero_documento
            // 
            this.numero_documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.numero_documento.DataPropertyName = "numero_documento";
            this.numero_documento.HeaderText = "Numero de documento";
            this.numero_documento.MinimumWidth = 6;
            this.numero_documento.Name = "numero_documento";
            this.numero_documento.ReadOnly = true;
            this.numero_documento.Width = 165;
            // 
            // nombre_completo_razon_social
            // 
            this.nombre_completo_razon_social.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombre_completo_razon_social.DataPropertyName = "nombre_completo_razon_social";
            this.nombre_completo_razon_social.HeaderText = "Nombre o Razón social";
            this.nombre_completo_razon_social.MinimumWidth = 6;
            this.nombre_completo_razon_social.Name = "nombre_completo_razon_social";
            this.nombre_completo_razon_social.ReadOnly = true;
            this.nombre_completo_razon_social.Width = 136;
            // 
            // celular
            // 
            this.celular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "Celular";
            this.celular.MinimumWidth = 6;
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Width = 81;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Dirección";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // frmListaMaquinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 689);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvListado);
            this.Name = "frmListaMaquinaria";
            this.Text = "frmListaMaquinaria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_completo_razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
    }
}