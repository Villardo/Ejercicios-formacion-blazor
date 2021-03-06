using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosBlazorSPA.Data
{
    public class Tarea
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public bool EstaChecked { get; set; }
        public int IdLista { get; set; }
        //public string Comentario { get; set; }

        public Tarea Clone()
        {
            return new Tarea
            {
                Id = this.Id,
                Nombre = this.Nombre,
                EstaChecked = this.EstaChecked
            };
        }
    }
}
