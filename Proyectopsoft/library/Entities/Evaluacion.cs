using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Evaluacion
    {
        public int Id { get; set; }

        [Display(Name = "Calificación de actividad")]
        [MaxLength(1, ErrorMessage = "La calificación no puede ser mayor de 1 caracter")]
        [Required(ErrorMessage = "La calificación es obligatoria")]
        [RegularExpression(@"^[0-5]+$", ErrorMessage = "La calificación solo debe contener números")]
        public int Calificacion { get; set; }

        [Display(Name = "Comentario de la actividad")]
        [MaxLength(200, ErrorMessage = "El comentario no puede tener más de 200 caracteres")]
        [Required(ErrorMessage = "El comentario es obligatorio")]
        public string Comentario { get; set; }
        public int IdActividad { get; set; }
        public Actividad Actividad { get; set; }

        public int IdEmpleado { get; set; }
        public Empleado Empleado { get; set; }
    }
}
