using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Circulo : Forma
    {
        public Circulo(decimal lado)
        {
            Nombre = "Círculo";
            NombrePlural = "Círculos";
            NombreIngles = "Circle";
            NombreInglesPlural = "Circles";
            Lado = lado;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (Lado / 2) * (Lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * Lado;
        }
    }
}
