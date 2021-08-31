using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class MaquinariaDTO
    {
        public int id { get; set; }
        public string equipo { get; set; }
        public string numero_serie { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string estado { get; set; }
        public DateTime fecha_compra { get; set; }
        public int ciclo_horas_mtto { get; set; }
        public int horas_alquiler_defecto { get; set; }
        public decimal precio_dia_defecto { get; set; }
    }
}
