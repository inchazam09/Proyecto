using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class Usuario
    {
        private string nombre;
        private string cedula;
        private string genero;
        private DateTime fechaRegistro;
        private string estado;
        private string nombreusuario;
        private string contraseña;
        private string confirmacion;

       

        public Usuario(string nombre, string cedula, string genero, DateTime fechaRegistro, string estado, string nombreusuario, string contraseña, string confirmacion)
        {
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.Genero = genero;
            this.FechaRegistro = fechaRegistro;
            this.Estado = estado;
            this.Nombreusuario = nombreusuario;
            this.Contraseña = contraseña;
            this.Confirmacion = confirmacion;
        }

        public Usuario()
        {
            this.Nombre = "";
            this.Cedula = "";
            this.Genero = "";
            this.FechaRegistro = DateTime.Today;
            this.Estado = "";
            this.Nombreusuario = "";
            this.Contraseña = "";
            this.Confirmacion = "";
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Genero { get => genero; set => genero = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Nombreusuario { get => nombreusuario; set => nombreusuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Confirmacion { get => confirmacion; set => confirmacion = value; }
    }
}
