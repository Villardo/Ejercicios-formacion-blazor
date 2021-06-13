using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosBlazorSPA.Data
{
    public class MiDbContext : DbContext
    {
        public MiDbContext( DbContextOptions options) : base(options)
        {

        }

        public DbSet<Lista> Listas { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Paso> Pasos { get; set; }

        //public DbSet<Alumno> Alumnos { get; set; }

    }
}
