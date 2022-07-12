using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealityFirst.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string fotoURL { get; set; }

        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        public string Lugar { get; set; }

        public string Artista { get; set; }

        public Evento()
        {

        }
    }
}
