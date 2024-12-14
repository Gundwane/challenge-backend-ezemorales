using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public abstract class Forma
    {
        protected Forma()
        {
        }

        public string Nombre { get; set; }
        public string NombrePlural { get; set; }
        public string NombreIngles { get; set; }
        public string NombreInglesPlural { get; set; }
        public decimal Lado { get; set; }
        public int NumeroTipo { get; set; }

        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();

    }
}
