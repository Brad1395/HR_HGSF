using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursoHumano.Models
{
    public class Permiso
    {
        public int IDpermiso { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public string Justificado { get; set; }
        public int? IDEmpleado { get; set; }
        public string Sala { get; set; }
    }
}
