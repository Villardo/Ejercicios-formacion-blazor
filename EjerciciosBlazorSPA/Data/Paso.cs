using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosBlazorSPA.Data
{
    public class Paso
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public bool EstaChecked { get; set; }
        [Required]
        public int IdTarea { get; set; }
        public Paso Clone()
        {
            return new Paso
            {
                Id = this.Id,
                Nombre = this.Nombre,
                EstaChecked = this.EstaChecked
            };
        }
    }
}
