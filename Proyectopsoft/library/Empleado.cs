using System.Collections.Generic;

namespace library
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string AreaTrabajo { get; set; }
        public string MetasBienestar { get; set; }
        public string RestriccionesMedicas { get; set; }
        public string Disponibilidad { get; set; }
      public List<Empleadoactividad> EmpleadoActividades { get; set; }



    }
}