using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Actividad
    {
        [Required(ErrorMessage = "Id de actividad obligatorio")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre actividad obligatorio")]
        [MaxLength(40, ErrorMessage = "El nombre de la actividad no puede tener más de 40 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La fecha es obligatoria")]
        public DateTime Fecha { get; set; }
        public string Duracion { get; set; }
        [Required(ErrorMessage = "ID del programa obligatorio")]
        public int IdPrograma { get; set; }
        public PBienestar Programa { get; set; }
        public Evaluacion Evaluaciones { get; set; }
        public Empleadoactividad EmpleadoActividades { get; set; }

    }
}
