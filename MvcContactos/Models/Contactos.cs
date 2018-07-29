using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcContactos.Models
{
    public class Contactos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

    }
}
