namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONTRATO")]
    public partial class CONTRATO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTRATO()
        {
            DETALLE_CONTRATO = new HashSet<DETALLE_CONTRATO>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public DateTime fecha_inicio { get; set; }

        public DateTime fecha_fin { get; set; }

        [Required]
        [StringLength(150)]
        public string direccion { get; set; }

        public int? isCombustible { get; set; }

        public int? isTransporte { get; set; }

        [StringLength(500)]
        public string observaciones { get; set; }

        public int idCliente { get; set; }

        public decimal? monto_adicionales { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_CONTRATO> DETALLE_CONTRATO { get; set; }
    }
}
