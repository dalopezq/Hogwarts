using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hogwarts.Models;

namespace Hogwarts.Data
{
    public class HogwartsContext : DbContext
    {
        public HogwartsContext() { }

        public HogwartsContext (DbContextOptions<HogwartsContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nombre).HasMaxLength(20);
                entity.Property(e => e.Apellido).HasMaxLength(20);
                entity.Property(e => e.Identificacion).HasMaxLength(10);
                entity.Property(e => e.Edad).HasMaxLength(2);
                entity.Property(e => e.Escuela).HasMaxLength(20);

                entity.HasData(new Estudiante
                {
                    Id = 1,
                    Nombre = "David",
                    Apellido = "Lopez",
                    Identificacion = "20614527",
                    Edad = "29",
                    Escuela = "Gryffindor"
                });
            });
        }
    }
}
