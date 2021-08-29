namespace Model.Models
{
    using AutoMapper;
    using Model.DTO;
    using Model.Shared;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Text;

    [Table("CLIENTE")]
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            ADJUNTOS = new HashSet<ADJUNTO>();
            CONTRATOes = new HashSet<CONTRATO>();
        }

        public int id { get; set; }

        [Required(ErrorMessage ="El dni o ruc es obligatorio.")]
        [StringLength(11)]
        public string dni_ruc { get; set; }

        [Required(ErrorMessage = "El nombre o razón social es obligatorio.")]
        [StringLength(75)]
        public string nombres_razonsocial { get; set; }

        [StringLength(75)]
        public string apellidos { get; set; }

        [StringLength(50)]
        public string telefono { get; set; }

        [Required(ErrorMessage = "El celular es obligatorio.")]
        [StringLength(50)]
        public string celular { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria.")]
        [StringLength(150)]
        public string direccion { get; set; }

        [StringLength(500)]
        public string observaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADJUNTO> ADJUNTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO> CONTRATOes { get; set; }

        AlquilerMaquinariaContext context; 

        public ResponseModel<List<CLIENTE>> Listar()
        {
            context = new AlquilerMaquinariaContext();
            var response = new ResponseModel<List<CLIENTE>>();

            try
            {
                response.data = context.CLIENTEs.ToList();
                response.Response = true;
                response.Message = "El cliente fue guardado exitosamente.";
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

        public ResponseModel<int> Guardar(CLIENTE cliente)
        {
            context = new AlquilerMaquinariaContext();
            var response = new ResponseModel<int>();
            
            try
            {
                context.CLIENTEs.Add(cliente);
                context.SaveChanges();
                response.Response = true;
                response.Message = "El cliente fue guardado exitosamente.";
            }
            catch(DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach(var error in ex.EntityValidationErrors)
                {
                    foreach(var item in error.ValidationErrors)
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


    }
}
