using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleControl.Models;

namespace VehicleControl.Data
{
    public class VehicleControlContext : DbContext
    {
        public VehicleControlContext (DbContextOptions<VehicleControlContext> options)
            : base(options)
        {
        }

        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<Anuncio> Anuncio { get; set; }
    }
}
