using System;
using System.Collections.Generic;

namespace VehicleControl.Models
{
    public class Marca
    {
        public int  id { get; set; }
        public string  name { get; set; }
        public ICollection<Modelo> Modelos { get; set; } = new List<Modelo>();

        public Marca()
        {
        }

        public Marca(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    


}
