namespace Model.Models
{
    using Model.Shared;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Text;

    [Table("MAQUINARIA")]
    public partial class MAQUINARIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAQUINARIA()
        {
            DETALLE_CONTRATO = new HashSet<DETALLE_CONTRATO>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(150)]
        public string equipo { get; set; }

        [Required]
        [StringLength(50)]
        public string numero_serie { get; set; }

        [Required]
        [StringLength(50)]
        public string marca { get; set; }

        [Required]
        [StringLength(50)]
        public string modelo { get; set; }

        [Required]
        [StringLength(50)]
        public string estado { get; set; }

        [StringLength(500)]
        public string observaciones { get; set; }

        public DateTime fecha_compra { get; set; }

        public int ciclo_horas_mtto { get; set; }

        public int horas_alquiler_defecto { get; set; }

        public decimal precio_dia_defecto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_CONTRATO> DETALLE_CONTRATO { get; set; }


        #region METODOS

        AlquilerMaquinariaContext context;
        public ResponseModel<List<MAQUINARIA>> Listar()
        {
            context = new AlquilerMaquinariaContext();
            var response = new ResponseModel<List<MAQUINARIA>>();

            try
            {
                response.data = context.MAQUINARIAs.ToList();
                response.Response = true;
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var error in ex.EntityValidationErrors)
                {
                    foreach (var item in error.ValidationErrors)
                    {
                        sb.Append(item.ErrorMessage);
                        sb.Append("\r\n");
                    }
                }
                response.Response = false;
                response.Message = sb.ToString();
            }
            catch (Exception ex)
            {
                response.Response = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public ResponseModel<MAQUINARIA> Obtener(int id)
        {
            context = new AlquilerMaquinariaContext();
            var response = new ResponseModel<MAQUINARIA>();

            try
            {
                response.data = context.MAQUINARIAs.FirstOrDefault(x => x.id == id);
                response.Response = true;
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var error in ex.EntityValidationErrors)
                {
                    foreach (var item in error.ValidationErrors)
                    {
                        sb.Append(item.ErrorMessage);
                        sb.Append("\r\n");
                    }
                }
                response.Response = false;
                response.Message = sb.ToString();
            }
            catch (Exception ex)
            {
                response.Response = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public ResponseModel<int> Guardar(MAQUINARIA maquinaria)
        {
            context = new AlquilerMaquinariaContext();
            var response = new ResponseModel<int>();

            try
            {
                if (maquinaria.id > 0)
                {
                    context.Entry(maquinaria).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    context.MAQUINARIAs.Add(maquinaria);
                }

                context.SaveChanges();
                response.Response = true;
                response.Message = "La maquinaria fue guardada exitosamente.";
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var error in ex.EntityValidationErrors)
                {
                    foreach (var item in error.ValidationErrors)
                    {
                        sb.Append(item.ErrorMessage);
                        sb.Append("\r\n");
                    }
                }
                response.Response = false;
                response.Message = sb.ToString();
            }
            catch (Exception ex)
            {
                response.Response = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public ResponseModel<int> Eliminar(int id)
        {
            context = new AlquilerMaquinariaContext();
            var response = new ResponseModel<int>();

            try
            {
                var maquinaria = new MAQUINARIA { id = id };

                context.MAQUINARIAs.Attach(maquinaria);
                context.MAQUINARIAs.Remove(maquinaria);
                context.SaveChanges();
                response.Response = true;
                response.Message = "La maquinaria fue eliminada.";
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var error in ex.EntityValidationErrors)
                {
                    foreach (var item in error.ValidationErrors)
                    {
                        sb.Append(item.ErrorMessage);
                        sb.Append("\r\n");
                    }
                }
                response.Response = false;
                response.Message = sb.ToString();
            }
            catch (Exception ex)
            {
                response.Response = false;
                response.Message = ex.Message;
            }
            return response;
        }

        #endregion
    }
}
