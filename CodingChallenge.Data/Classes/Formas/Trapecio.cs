using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Trapecio : Forma
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public Trapecio(double base1, double base2, double altura, double lado1, double lado2)
        {
            Nombre = "Trapecio";
            NombrePlural = "Trapecios";
            NombreIngles = "Trapezoid";
            NombreInglesPlural = "Trapezoids";
            Base1 = base1;
            Base2 = base2;
            Altura = altura;
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public override decimal CalcularArea()
        {
            return (decimal)((Base1 + Base2) * Altura / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)(Base1 + Base2 + Lado1 + Lado2);
        }
    }
}
