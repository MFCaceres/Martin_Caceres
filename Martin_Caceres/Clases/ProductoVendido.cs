using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Caceres.Clases
{
    public class ProductoVendido
    {
        private int Id { get; set; }
        [Required]
        public int IdProducto { get; set; }
        public double Stock { get; set; }
        [Required]
        private int IdVenta { get; set; }

        public ProductoVendido (int id, int idProducto, double stock, int idVenta)
        {
            Id = id;
            IdProducto = idProducto;
            Stock = stock;
            IdVenta = idVenta;
        }

        public ProductoVendido() { }
    }
}
