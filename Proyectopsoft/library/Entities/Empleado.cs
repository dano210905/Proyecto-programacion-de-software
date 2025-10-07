using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace library
{
    public class Empleado
    {

        public int Id { get; set; }

        [Display(Name = "Nombre del empleado")]
        [MaxLength(100, ErrorMessage = "El nombre  no puede tener más de 100 caracteres")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo debe contener letras")]

        public string Nombre { get; set; }

        [Display(Name = "Documento del empleado")]
        [MaxLength(15, ErrorMessage = "El documento no puede tener más de 15 caracteres")]
        [Required(ErrorMessage = "El documento es obligatorio")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El documento solo debe contener números")]
        public string Documento { get; set; }

        [Display(Name = "Cargo del empleado")]
        [MaxLength(100, ErrorMessage = "El Cargo no puede tener más de 100 caracteres")]
        [Required(ErrorMessage = "El cargo es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El cargo solo debe contener letras")]
        public string Cargo { get; set; }

        [Display(Name = "Area del empleado")]
        [MaxLength(100, ErrorMessage = "El area no puede tener más de 100 caracteres")]
        [Required(ErrorMessage = "El Area es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El Area solo debe contener letras")]
        public string AreaTrabajo { get; set; }

        [Display(Name = "Metas del empleado")]
        [MaxLength(100, ErrorMessage = "La meta no puede tener más de 100 caracteres")]
        [Required(ErrorMessage = "La meta es obligatoria")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "La meta solo debe contener letras")]
        public string MetasBienestar { get; set; }

        [Display(Name = "Restricciones del empleado")]
        [MaxLength(200, ErrorMessage = "Las restricciones no pueden tener más de 200 caracteres")]
        [Required(ErrorMessage = "Las restricciones son obligatorias")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Las restricciones solo deben contener letras")]
        public string RestriccionesMedicas { get; set; }

        [Display(Name = "Disponibilidad del empleado")]
        [MaxLength(100, ErrorMessage = "La disponibilidad no puede tener más de 100 caracteres")]
        [Required(ErrorMessage = "La disponibilidad es obligatoria")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "la disponibilidad solo debe contener letras")]
        public string Disponibilidad { get; set; }

        [Display(Name = "Telefono del empleado")]
        [MaxLength(15, ErrorMessage = "El area no puede tener más de 15 caracteres")]
        [Required(ErrorMessage = "El Area es obligatorio")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El telefono solo debe contener números")]
        public string Telefono { get; set; }



        public string Correo { get; set; }



        public List<Empleadoactividad> EmpleadoActividades { get; set; }



    }
}