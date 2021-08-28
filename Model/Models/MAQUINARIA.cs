namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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

        public DateTime fecha_compra { get; set; }

        public int ciclo_horas_mtto { get; set; }

        public int horas_alquiler_defecto { get; set; }

        public decimal precio_dia_defecto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_CONTRATO> DETALLE_CONTRATO { get; set; }
    }
}
