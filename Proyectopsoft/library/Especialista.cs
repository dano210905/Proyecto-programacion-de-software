using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Especialista
    {
        public int IdEspecialista { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Credenciales { get; set; }
        public string DisponibilidadHoraria { get; set; }
        public decimal Tarifa { get; set; }

        public List<PBienestar> Programas { get; set; }
    }
}
