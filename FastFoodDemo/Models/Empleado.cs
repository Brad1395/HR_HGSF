using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursoHumano.Models
{
    public class Empleado
    {
        public int IDEmpleado { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public int? TipoEmpleado { get; set; }
        public string TipoContrato { get; set; }
        public string TieneProfilactica { get; set; }
    }
}
