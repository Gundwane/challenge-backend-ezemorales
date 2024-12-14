using CodingChallenge.Data.Classes.Formas;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Castellano : Idioma
    {
        public Castellano()
        {
        }

        public override string ObtenerHeader()
        {
            return "<h1>Reporte de Formas</h1>";
        }

        public override string ObtenerLinea(FormaCalculos formaCalculos, int cantidadTotalDeFormas)
        {
            if (formaCalculos.Cantidad > 0)
            {
                return $"{formaCalculos.Cantidad} {TraducirForma(formaCalculos)} | Área {formaCalculos.AreaTotal:#.##} | Perímetro {formaCalculos.PerimetroTotal:#.##} <br/>";
            }

            return string.Empty;
        }

        public override string ObtenerFooter(Dictionary<string, FormaCalculos> formas)
        {
            int totalFormas = formas.Values.Sum(forma => forma.Cantidad);

            return $@"TOTAL:<br/>{totalFormas} formas Perímetro {formas.Values.Sum(forma => forma.PerimetroTotal):#.##} Área {formas.Values.Sum(forma => forma.AreaTotal):#.##}";
        }

        public override string ObtenerMensajeDeLineaVacia()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        public override string TraducirForma(FormaCalculos formaCalculos)
        {
            if (formaCalculos.Cantidad > 1)
                return formaCalculos.NombrePlural;

            return formaCalculos.Nombre;
        }
    }
}
