using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosBlazorSPA.Data
{
    public class Lista
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }

        public Lista Clone()
        {
            return new Lista
            {
                Id = this.Id,
                Nombre = this.Nombre
            };
        }
    }
}
