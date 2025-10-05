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
        [Required(ErrorMessage = "El nombre especialista obligatorio")]
        [MaxLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La especialidad es oblgiatoria")]
        public string Especialidad { get; set; }
        public string Credenciales { get; set; }
        public string DisponibilidadHoraria { get; set; }
        [Required(ErrorMessage = "La tarifa es obligatoria")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Tarifa { get; set; }

        public List<PBienestar> Programas { get; set; }
    }
}
