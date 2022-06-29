using Microsoft.EntityFrameworkCore;
using RealityFirst.Models;

namespace RealityFirst.Datos

{
    public class ContextDB:DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options):base(options)
        {
               
        }
        public DbSet<Evento> eventos { get; set; }
    }
}
