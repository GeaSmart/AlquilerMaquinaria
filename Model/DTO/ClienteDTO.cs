using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.DTO
{
    public class ClienteDTO
    {
        public int id { get; set; }
        public string dni_ruc { get; set; }
        public string nombres_razonsocial { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string direccion { get; set; }
        public string observaciones { get; set; }
    }
}
