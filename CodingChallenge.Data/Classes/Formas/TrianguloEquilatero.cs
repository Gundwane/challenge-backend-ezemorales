using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public class TrianguloEquilatero : Forma
    {
        public TrianguloEquilatero(decimal lado)
        {
            Nombre = "Triángulo";
            NombrePlural = "Triángulos";
            NombreIngles = "Triangle";
            NombreInglesPlural = "Triangles";
            Lado = lado;
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return Lado * 3;
        }
    }
}
