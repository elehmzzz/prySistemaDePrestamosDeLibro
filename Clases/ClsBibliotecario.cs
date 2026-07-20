using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal class ClsBibliotecario : Persona
    {
        private int IdBibliotecario { get; }
        private string Usuario { get; set; } 
        private string Contraseña { get; set; }


    }
}
