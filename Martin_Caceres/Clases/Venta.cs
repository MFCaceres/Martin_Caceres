using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Caceres.Clases
{
    public class Venta
    {
        [Required]
        private int Id { get; set; }
        [MaxLength(100)]
        public string Comentarios { get; set; }

        public Venta (int id, string comentarios)
        {
            Id = id;
            Comentarios = comentarios;
        }
        
        public Venta() { }
    }
}
