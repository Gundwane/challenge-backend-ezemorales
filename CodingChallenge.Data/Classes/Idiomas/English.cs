using CodingChallenge.Data.Classes.Formas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class English : Idioma
    {
        public English()
        {
        }

        public override string ObtenerHeader()
        {
            return "<h1>Shapes report</h1>";
        }

        public override string ObtenerFooter(Dictionary<string, FormaCalculos> formas)
        {
            int totalFormas = formas.Values.Sum(forma => forma.Cantidad);

            return $@"TOTAL:<br/>{totalFormas} shapes Perimeter {formas.Values.Sum(forma => forma.PerimetroTotal):#.##} Area {formas.Values.Sum(forma => forma.AreaTotal):#.##}";
        }

        public override string ObtenerMensajeDeLineaVacia()
        {
            return "<h1>Empty list of shapes!</h1>";
        }

        public override string TraducirForma(FormaCalculos formaCalculos)
        {
            if (formaCalculos.Cantidad > 1)
                return formaCalculos.NombrePluralIngles;

            return formaCalculos.NombreIngles;
        }

        public override string ObtenerLinea(FormaCalculos formaCalculos, int cantidadTotalDeFormas)
        {
            if (formaCalculos.Cantidad > 0)
            {
                return $"{formaCalculos.Cantidad} {TraducirForma(formaCalculos)} | Area {formaCalculos.AreaTotal:#.##} | Perimeter {formaCalculos.PerimetroTotal:#.##} <br/>";
            }

            return string.Empty;
        }
    }
}
