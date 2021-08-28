namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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

        [Required]
        [StringLength(11)]
        public string dni_ruc { get; set; }

        [Required]
        [StringLength(75)]
        public string nombres_razonsocial { get; set; }

        [StringLength(75)]
        public string apellidos { get; set; }

        [StringLength(50)]
        public string telefono { get; set; }

        [Required]
        [StringLength(50)]
        public string celular { get; set; }

        [Required]
        [StringLength(150)]
        public string direccion { get; set; }

        [StringLength(500)]
        public string observaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADJUNTO> ADJUNTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO> CONTRATOes { get; set; }

        AlquilerMaquinariaContext context = new AlquilerMaquinariaContext();

        public bool Guardar(CLIENTE cliente)
        {
            context.CLIENTEs.Add(cliente);
            context.SaveChanges();
            return true;
        }
    }
}
