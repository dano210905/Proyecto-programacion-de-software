using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Actividad
    {

        public int IdActividad { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Duracion { get; set; }

        public int IdPrograma { get; set; }
        public PBienestar Programa { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }
        public List<Empleadoactividad> EmpleadoActividades { get; set; }

    }
}
