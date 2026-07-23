using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaDePrestamosDeLibro.Clases
{
    internal abstract class Persona
    {
        protected private string Nombre;
        protected string aPaterno;
        protected string aMaterno;
        protected DateOnly fechaNac;
        protected string correo;
        protected string telefono;
        protected DateOnly fechaRegistro;

        public string getNombre() {
            return Nombre;
        }
        public void setNombre(string nombre) {
            Nombre = nombre;
        }
        public string getAPaterno() {
            return aPaterno;
        }
        public void setAPaterno(string aPaterno) {
            this.aPaterno = aPaterno;
        }
        public string getAMaterno() {
            return aMaterno;
        }
        public void setAMaterno(string aMaterno) {
            this.aMaterno = aMaterno;
        }
        public DateOnly getFechaNac() {
            return fechaNac;
        }
        public void setFechaNac(DateOnly fechaNac) {
            this.fechaNac = fechaNac;
        }
        public string getCorreo() {
            return correo;
        }
        public void setCorreo(string correo) {
            this.correo = correo;
        }
        public string getTelefono() {
            return telefono;
        }
        public void setTelefono(string telefono) {
            this.telefono = telefono;
        }
        public DateOnly getFechaRegistro() {
            return fechaRegistro;
        }
        public void setFechaRegistro(DateOnly fechaRegistro) {
            this.fechaRegistro = fechaRegistro;
        }
        //constuctor
        public Persona() {
        }
        //constructor parametrizado
        public Persona(string nombre, string aPaterno, string aMaterno, string telefono, string correo) {
            Nombre = nombre;
            this.aPaterno = aPaterno;
            this.aMaterno = aMaterno;
            this.telefono = telefono;
            this.correo = correo;
        }
    }
}
