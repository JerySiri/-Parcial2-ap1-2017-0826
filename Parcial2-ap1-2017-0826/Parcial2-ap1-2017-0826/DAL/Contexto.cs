using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Parcial2_ap1_2017_0826.Entidades;

namespace Parcial2_ap1_2017_0826.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<TipoTarea> TipoTarea { get; set; }
        public DbSet<ProyectosDetalle> ProyectosDetalle { get; set; }
        public DbSet<Proyectos> Proyectos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\Proyectos.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TipoTarea>().HasData(
                
                new TipoTarea() { TareaId = 1, Nombre = "Analisis" },
                new TipoTarea() { TareaId = 2, Nombre = "Diseño" },
                new TipoTarea() { TareaId = 3, Nombre = "Programación" },
                new TipoTarea() { TareaId = 4, Nombre = "Prueba" }

           );
        }
    }
}
