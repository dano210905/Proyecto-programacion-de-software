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
        public int IdPrograma { get; set; }
        [MaxLength(30, ErrorMessage = "El nombre del programa no puede tener más de 30 caracteres")]
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Duracion { get; set; }
        public string Modalidad { get; set; }
        public string Frecuencia { get; set; }

        //relaciones
        public int IdEspecialista { get; set; }
        public Especialista Especialista { get; set; }
        public List<Actividad> Actividades { get; set; }

    }
}
