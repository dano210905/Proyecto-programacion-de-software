using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace library
{
    public class Empleado
    {

        [Required(ErrorMessage = "Id de empleado obligatorio")]
        public int Id { get; set; }
        [MaxLength(20, ErrorMessage = "El nombre  no puede tener más de 25 caracteres")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo debe contener letras")]

        public string Nombre { get; set; }
        [Required(ErrorMessage = "El documento es obligatorio")]
        [MaxLength(15, ErrorMessage = "El documento no puede tener mas de 15 caracteres")]
        public string Documento { get; set; }
        [Required(ErrorMessage = "El cargo es obligatorio")]
        public string Cargo { get; set; }
        [Required(ErrorMessage = "El area de trabajo es obligatoria")]
        public string AreaTrabajo { get; set; }
        public string MetasBienestar { get; set; }
        public string RestriccionesMedicas { get; set; }
        [Required(ErrorMessage = "La    disponibilidad no es obligatoria")]
        public string Disponibilidad { get; set; }
        [Required(ErrorMessage = "El Telefono")]
        public string Telefono { get; set; }

        public string Correo { get; set; }
        // relaciones

        public List<Empleadoactividad> EmpleadoActividades { get; set; }



    }
}