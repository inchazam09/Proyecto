using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class Torneos
    {
        private DateTime fechaTorneo;
        private string premio;
        private string usuario;
        private string ganador;

       

        public Torneos(DateTime fechaTorneo, string premio, string usuario, string ganador)
        {
            this.FechaTorneo = fechaTorneo;
            this.Premio = premio;
            this.Usuario = usuario;
            this.Ganador = ganador;
        }

        public Torneos()
        {
            this.FechaTorneo = DateTime.Today;
            this.Premio = "";
            this.Usuario = "";
            this.Ganador = "";
        }

        protected DateTime FechaTorneo { get => fechaTorneo; set => fechaTorneo = value; }
        protected string Premio { get => premio; set => premio = value; }
        protected string Usuario { get => usuario; set => usuario = value; }
        protected string Ganador { get => ganador; set => ganador = value; }
    }
}
