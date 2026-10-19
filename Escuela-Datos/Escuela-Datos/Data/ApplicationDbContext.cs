using Escuela_Datos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Escuela_Datos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        public virtual DbSet<Escuela> Escuela {  get; set; }
        public virtual DbSet<Alumno> Alumno { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=LAPTOP-JC5GM4OO\\SQLEXPRESS04;User Id=sa;Password=123;Database=Escuela_Datos;TrustServerCertificate=true"

                );

        }
    }
}
