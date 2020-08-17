using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleControl.Models
{
    public class Modelo
    {
        public int id { get; set; }
        public string Detalhe { get; set; }
        public ICollection<Anuncio> Anuncios { get; set; } = new List<Anuncio>();


        public Modelo()
        {
        }
        public Modelo(int id, string detalhe)
        {
            Detalhe = detalhe;
        }
    }
}
