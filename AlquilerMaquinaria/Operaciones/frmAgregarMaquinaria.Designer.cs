
namespace AlquilerMaquinaria.Operaciones
{
    partial class frmAgregarMaquinaria
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaquinaria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNumeroDias = new System.Windows.Forms.NumericUpDown();
            this.nudHorasUsoMtto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPrecioDia = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSubtotal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasUsoMtto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione maquinaria";
            // 
            // cmbMaquinaria
            // 
            this.cmbMaquinaria.FormattingEnabled = true;
            this.cmbMaquinaria.Location = new System.Drawing.Point(226, 61);
            this.cmbMaquinaria.Name = "cmbMaquinaria";
            this.cmbMaquinaria.Size = new System.Drawing.Size(431, 24);
            this.cmbMaquinaria.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Num dias";
            // 
            // nudNumeroDias
            // 
            this.nudNumeroDias.Location = new System.Drawing.Point(226, 122);
            this.nudNumeroDias.Name = "nudNumeroDias";
            this.nudNumeroDias.Size = new System.Drawing.Size(120, 22);
            this.nudNumeroDias.TabIndex = 3;
            // 
            // nudHorasUsoMtto
            // 
            this.nudHorasUsoMtto.Location = new System.Drawing.Point(226, 150);
            this.nudHorasUsoMtto.Name = "nudHorasUsoMtto";
            this.nudHorasUsoMtto.Size = new System.Drawing.Size(120, 22);
            this.nudHorasUsoMtto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "horas uso mtto";
            // 
            // nudPrecioDia
            // 
            this.nudPrecioDia.Location = new System.Drawing.Point(226, 178);
            this.nudPrecioDia.Name = "nudPrecioDia";
            this.nudPrecioDia.Size = new System.Drawing.Size(120, 22);
            this.nudPrecioDia.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "precio por dia";
            // 
            // nudSubtotal
            // 
            this.nudSubtotal.Location = new System.Drawing.Point(226, 206);
            this.nudSubtotal.Name = "nudSubtotal";
            this.nudSubtotal.Size = new System.Drawing.Size(120, 22);
            this.nudSubtotal.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Subtotal";
            // 
            // nudDescuento
            // 
            this.nudDescuento.Location = new System.Drawing.Point(226, 234);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(120, 22);
            this.nudDescuento.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descuento";
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(700, 319);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(99, 40);
            this.btnAnadir.TabIndex = 12;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(595, 319);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 40);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAgregarMaquinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 607);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.nudDescuento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudSubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudPrecioDia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudHorasUsoMtto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudNumeroDias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMaquinaria);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarMaquinaria";
            this.Text = "frmAgregarMaquinaria";
            this.Load += new System.EventHandler(this.frmAgregarMaquinaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasUsoMtto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaquinaria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNumeroDias;
        private System.Windows.Forms.NumericUpDown nudHorasUsoMtto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPrecioDia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnCancelar;
    }
}