using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

using System.ComponentModel.DataAnnotations;

namespace library
{
    public class PBienestar
    {
        [Required(ErrorMessage = "El id del programa es obligatorio")]
        public int Id{ get; set; }

        [Display(Name = "Nombre programa")]
        [MaxLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo debe contener letras")]
        public string Nombre { get; set; }

        [Display(Name = "Categoria del Programa")]
        [MaxLength(50, ErrorMessage = "La categoria no puede tener más de 50 caracteres")]
        [Required(ErrorMessage = "La categoria es obligatoria")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "La categoria solo debe contener letras")]
        public string Categoria { get; set; }

        [Display(Name = "Duración del programa")]
        [MaxLength(100, ErrorMessage = "La duración no puede tener más de 100 caracteres")]
        [Required(ErrorMessage = "La duración es obligatoria")]
        public string Duracion { get; set; }

        [Display(Name = "Modalidad programa")]
        [MaxLength(25, ErrorMessage = "El nombre no puede tener más de 25 caracteres")]
        [Required(ErrorMessage = "La modalidad es obligatoria")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "La modalidad solo debe contener letras")]
        public string Modalidad { get; set; }

        [Display(Name = "Frecuencia programa")]
        [MaxLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        [Required(ErrorMessage = "La frecuencia es obligatoria")]
        public string Frecuencia { get; set; }

        //relaciones
        public int IdEspecialista { get; set; }
        public Especialista Especialista { get; set; }
        public List<Actividad> Actividades { get; set; }

    }
}
