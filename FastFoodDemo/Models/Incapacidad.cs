using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursoHumano.Models
{
    public class Incapacidad
    {
        public int IDIncapacidad { get; set; }
        public int? IDEmpleado { get; set; }
        public string Medico { get; set; }
        public string Diagnostico { get; set; }
        public string NotificaJefe { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
    }
}
