using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace library
{
    public class Empleado
    {

        public int Id { get; set; }

        [Display(Name ="Nombre Empleado")]
        [MaxLength(100, ErrorMessage = "El nombre  no puede tener más de 100 caracteres")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo debe contener letras")]

        public string Nombre { get; set; }

        [Display(Name = "Documento Empleado")]
        [Required(ErrorMessage = "El documento es obligatorio")]
        [MaxLength(15, ErrorMessage = "El documento no puede tener mas de 15 caracteres")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El nombre solo debe contener números")]
        public string Documento { get; set; }

        [Display(Name = "Cargo Empleado")]
        [Required(ErrorMessage = "El Cargo es obligatorio")]
        [MaxLength(100, ErrorMessage = "El cargo no puede tener mas de 100 caracteres")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo debe contener letras")]
        public string Cargo { get; set; }

        [Display(Name = "Area de trabajo")]
        [Required(ErrorMessage = "El area de trabajo es obligatoria")]
        [MaxLength(100, ErrorMessage = "El documento no puede tener mas de 100 caracteres")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El Area de Trabajo solo debe contener letras")]
        public string AreaTrabajo { get; set; }

        [Display(Name = "Metas Bienestar")]
        [Required(ErrorMessage = "Las Metas de Bienestar son obligatorias")]
        [MaxLength(100, ErrorMessage = "El documento no puede tener mas de 100 caracteres")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Las metas de bienestar solo deben contener letras")]
        public string MetasBienestar { get; set; }

        [Display(Name = "Restricciones Medicas")]
        [Required(ErrorMessage = "Las restricciones medicas son obligatorias")]
        [MaxLength(100, ErrorMessage = "El documento no puede tener mas de 100 caracteres")]
        public string RestriccionesMedicas { get; set; }

        [Display(Name = "Disponibilidad")]
        [Required(ErrorMessage = "La disponibilidad es obligatoria")]
        [MaxLength(50, ErrorMessage = "El documento no puede tener mas de 50 caracteres")]
        public string Disponibilidad { get; set; }

        [Display(Name = "Telefono Empleado")]
        [Required(ErrorMessage = "El telefono es obligatorio")]
        [MaxLength(20, ErrorMessage = "El telefono no puede tener mas de 20 caracteres")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El telefono solo debe contener números")]
        public string Telefono { get; set; }

        [Display(Name = "Correo Empleado")]
        [Required(ErrorMessage = "El correo es obligatorio")]
        [MaxLength(50, ErrorMessage = "El correo no puede tener mas de 50 caracteres")]
        public string Correo { get; set; }
        // relaciones

        public List<Empleadoactividad> EmpleadoActividades { get; set; }



    }
}