namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADJUNTOS")]
    public partial class ADJUNTO
    {
        public int id { get; set; }

        [Required]
        [StringLength(150)]
        public string descripcion { get; set; }

        [Required]
        [StringLength(150)]
        public string ruta { get; set; }

        public int? idCliente { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }
    }
}
