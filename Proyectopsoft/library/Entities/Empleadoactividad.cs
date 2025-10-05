using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Empleadoactividad
    {
        [Required(ErrorMessage = "Id de empleado obligatorio")]
        public int IdEmpleado { get; set; }
        public Empleado Empleado { get; set; }

        [Required(ErrorMessage = "Id de la actividad es obligatorio")]
        public int IdActividad { get; set; }
        public Actividad Actividad { get; set; }
        public List<Empleadoactividad> EmpleadoActividades { get; set; }

    }
}
