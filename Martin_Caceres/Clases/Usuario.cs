using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Caceres.Clases
{
    public class Usuario
    {
        private int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string NombreUsuario { get; set; }

        [Required]
        [MaxLength(8)]
        private string Contraseña { get; set; } 
        public string Mail { get; set; }

        public Usuario (int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Mail = mail;
        }   

        public Usuario() { }


    }
}
