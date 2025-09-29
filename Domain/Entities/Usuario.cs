using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
