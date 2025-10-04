using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Empleadoactividad
    {
        public int IdEmpleado { get; set; }
        public Empleado Empleado { get; set; }

        public int IdActividad { get; set; }
        public Actividad Actividad { get; set; }
        public List<Empleadoactividad> EmpleadoActividades { get; set; }

    }
}
