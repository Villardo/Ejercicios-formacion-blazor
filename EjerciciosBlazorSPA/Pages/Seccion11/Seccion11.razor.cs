﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosBlazorSPA.Pages.Seccion11
{
    public partial class Seccion11
    {
        public List<Persona> Personas { get; set; }
        public List<Persona> PersonasFiltradas { get; set; } = new();

        
        protected override void OnInitialized()
        {
            Personas = new()
            {
                new Persona { Nombre = "Nombre 1", Apellido = "Apellido 1", Edad = 1 },
                new Persona { Nombre = "Nombre 2", Apellido = "Apellido 2", Edad = 2 },
                new Persona { Nombre = "Nombre 3", Apellido = "Apellido 3", Edad = 3 },
                new Persona { Nombre = "Nombre 4", Apellido = "Apellido 4", Edad = 4 }
            };
        }

        public void DameMenoresQue3()
        {
            PersonasFiltradas = Personas.Where(miPersona => miPersona.Edad < 3).ToList();
            
        }
        public void DamePersonas()
        {
            PersonasFiltradas = Personas
                //.Select(miPersona => miPersona.Nombre)
                .Where(miPersona => miPersona.Edad < 6)
                //.Where(miPersona => miPersona.Edad < 6 && miPersona.Nombre == "Nombre 4")
                .Where(miPersona => miPersona.Nombre == "Nombre 4")
                .OrderByDescending(miPersona => miPersona.Edad).ToList();
        }
    }
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }
}

