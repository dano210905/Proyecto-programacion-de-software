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

        [Display(Name = "Nombre Actividad")]
        [MaxLength(100, ErrorMessage = "El area no puede tener más de 100 caracteres")]
        [Required(ErrorMessage = "El Area es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El Area solo debe contener letras")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La fecha es obligatoria")]
        public DateTime Fecha { get; set; }

        [Display(Name = "Duración de la actividad")]
        [MaxLength(100, ErrorMessage = "La duración no puede tener más de 100 caracteres")]
        [Required(ErrorMessage = "La duración es obligatoria")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El Area solo debe contener letras")]
        public string Duracion { get; set; }
        [Required(ErrorMessage = "ID del programa obligatorio")]
        public int IdPrograma { get; set; }
        public PBienestar Programa { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }
        public List<Empleadoactividad> EmpleadoActividades { get; set; }

    }
}
