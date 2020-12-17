using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursoHumano.Models
{
    public class Vacaciones
    {
        public int IDVac { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Final { get; set; }
        public string TipoVacacion { get; set; }
        public int? IDEmpleado { get; set; }
    }
}
