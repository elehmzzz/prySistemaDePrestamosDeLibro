using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal abstract class Persona
    {
        protected private string Nombre { get; set; }
        protected string aPaterno { get; set; }
        protected string aMaterno { get; set; }
        protected DateOnly fechaNac { get; set; }
        protected string correo { get; set; }
        protected string telefono { get; set; }
        protected DateOnly fechaRegistro { get; set; }
    }
}
