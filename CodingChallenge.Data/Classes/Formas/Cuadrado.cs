using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Cuadrado : Forma
    {
        public Cuadrado(decimal lado)
        {
            Nombre = "Cuadrado";
            NombrePlural = "Cuadrados";
            NombreIngles = "Square";
            NombreInglesPlural = "Squares";
            Lado = lado;
        }

        public override decimal CalcularArea()
        {
            return Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return Lado * 4;
        }
    }
}
