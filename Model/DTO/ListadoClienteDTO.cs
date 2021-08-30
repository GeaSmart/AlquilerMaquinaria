using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.DTO
{
    public class ListadoClienteDTO
    {
        public int id { get; set; }
        public string tipo_documento { get; set; }
        public string numero_documento { get; set; }
        public string nombre_completo_razon_social { get; set; }
        public string celular { get; set; }
        public string direccion { get; set; }
    }
}
