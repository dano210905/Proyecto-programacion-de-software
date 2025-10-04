using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class PBienestar
    {
        public int IdPrograma { get; set; }
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
