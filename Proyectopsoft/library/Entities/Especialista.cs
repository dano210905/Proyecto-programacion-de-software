using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Especialista
    {
        [Required(ErrorMessage = "Id especialista obligatorio")]
        public int Id { get; set; }

        [Display(Name = "Nombre del Especialista")]
        [MaxLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo debe contener letras")]
        public string Nombre { get; set; }

        [Display(Name = "Especilidad del Especialista")]
        [MaxLength(100, ErrorMessage = "La especialidad no puede tener más de 100 caracteres")]
        [Required(ErrorMessage = "La especialidad es obligatoria")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "La especialidad solo debe contener letras")]
        public string Especialidad { get; set; }

        [Display(Name = "Credenciales del Especialista")]
        [MaxLength(200, ErrorMessage = "Las credenciales no puede tener más de 200 caracteres")]
        [Required(ErrorMessage = "Las credenciales son obligatorias")]
        public string Credenciales { get; set; }

        [Display(Name = "Disponibilidad del Especialista")]
        [MaxLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        [Required(ErrorMessage = "La disponibilidad es obligatoria")]

        public string DisponibilidadHoraria { get; set; }

        [Display(Name = "Tarifa del Especialista")]
        [Required(ErrorMessage = "La tarifa es obligatoria")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Tarifa { get; set; }

    }
}
