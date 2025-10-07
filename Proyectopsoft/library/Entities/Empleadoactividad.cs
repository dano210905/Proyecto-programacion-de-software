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
        [JsonIgnore]
        public Empleado Empleado { get; set; }
        public int EmpleadoId { get; set; }

        [JsonIgnore]
        public Actividad Actividad { get; set; }

        public int IdActividad { get; set; }

        [Display(Name = "Comentarios Empleado")]
        [MaxLength(200, ErrorMessage = "El comentario no puede tener más de 200 caracteres")]

        public int Id { get; set; }
        public string Comentario { get; set; }

        [Display(Name = "Calificacion empleado")]
        [Required(ErrorMessage = "La calificación es obligatoria")]
        [MaxLength(1, ErrorMessage = "La calificación no puede tener mas de 1 caracter")]
        [RegularExpression(@"^[0-5]+$", ErrorMessage = "El nombre solo debe contener números")]
        public string Calificacion { get; set; }
    }
}
