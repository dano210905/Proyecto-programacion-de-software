using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Evaluacion
    {
        public int IdEvaluacion { get; set; }
        public int Calificacion { get; set; }
        public string Comentario { get; set; }
        public int IdActividad { get; set; }
        public Actividad Actividad { get; set; }

        public int IdEmpleado { get; set; }
        public Empleado Empleado { get; set; }
    }
}
