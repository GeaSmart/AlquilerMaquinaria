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
        public string marca { get; set; }
        public string modelo { get; set; }
        public string estado { get; set; }
    }
}
