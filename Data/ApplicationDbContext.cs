using Microsoft.EntityFrameworkCore;
using BioSportWeb.Models;

namespace BioSportWeb.Data // Asegúrate que sea exactamente este namespace
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Planes> Planes { get; set; }
    }
}