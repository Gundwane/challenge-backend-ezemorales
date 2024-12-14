using CodingChallenge.Data.Classes.Contracts;
using CodingChallenge.Data.Classes.Formas;
using CodingChallenge.Data.Classes.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class GeneradorDeReporte : IGeneradorDeReporte
    {
        private readonly Idioma _idioma;

        public GeneradorDeReporte(Idioma idioma)
        {
            _idioma = idioma;
        }

        public string Imprimir(List<Forma> formas)
        {
            var stringBuilder = new StringBuilder();

            if (!formas.Any())
            {
                stringBuilder.Append(_idioma.ObtenerMensajeDeLineaVacia());
            }
            else
            {
                // HEADER
                stringBuilder.Append(_idioma.ObtenerHeader());

                var calculos = ObtenerCalculos(formas);

                GenerarLineasDeFormas(calculos, stringBuilder);

                // FOOTER
                stringBuilder.Append(_idioma.ObtenerFooter(calculos));
            }

            return stringBuilder.ToString();
        }

        private Dictionary<string, FormaCalculos> ObtenerCalculos(List<Forma> formas)
        {
            var calculos = new Dictionary<string, FormaCalculos>();

            foreach (Forma forma in formas)
            {
                FormaCalculos formaCalculos = new FormaCalculos();
                var tipoDeForma = forma.GetType().Name;

                if (!calculos.ContainsKey(tipoDeForma))
                {
                    calculos[tipoDeForma] = new FormaCalculos();
                }

                calculos[tipoDeForma].Nombre = forma.Nombre;
                calculos[tipoDeForma].NombrePlural = forma.NombrePlural;
                calculos[tipoDeForma].NombreIngles = forma.NombreIngles;
                calculos[tipoDeForma].NombrePluralIngles = forma.NombreInglesPlural;
                calculos[tipoDeForma].Cantidad++;
                calculos[tipoDeForma].AreaTotal += forma.CalcularArea();
                calculos[tipoDeForma].PerimetroTotal += forma.CalcularPerimetro();
            }

            return calculos;
        }

        private void GenerarLineasDeFormas(Dictionary<string, FormaCalculos> calculos, StringBuilder stringBuilder)
        {
            foreach (var forma in calculos)
            {
                stringBuilder.Append(_idioma.ObtenerLinea(forma.Value, calculos.Values.Sum(f => f.Cantidad)));
            }
        }

    }
}
