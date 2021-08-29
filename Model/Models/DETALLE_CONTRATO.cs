namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    
    public partial class DETALLE_CONTRATO
    {
        //[Key]
        //[Column(Order = 0)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, Column(Order = 1)]
        public int idContrato { get; set; }

        //[Key]
        //[Column(Order = 1)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, Column(Order = 2)]
        public int idMaquinaria { get; set; }

        //public int numero_dias { get; set; }

        //public int horas_uso_total_mtto { get; set; }

        //public decimal monto_precio_dia { get; set; }

        //public decimal? monto_subtotal { get; set; }

        //public decimal? monto_descuento { get; set; }

        //public virtual CONTRATO CONTRATO { get; set; }

        //public virtual MAQUINARIA MAQUINARIA { get; set; }
    }
}
