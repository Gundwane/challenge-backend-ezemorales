using CodingChallenge.Data.Classes.Formas;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public abstract class Idioma
    {
        protected Idioma()
        {
        }

        public abstract string ObtenerLinea(FormaCalculos formaCalculos, int cantidadTotalDeFormas);
        public abstract string TraducirForma(FormaCalculos formaCalculos);
        public abstract string ObtenerMensajeDeLineaVacia();
        public abstract string ObtenerHeader();
        public abstract string ObtenerFooter(Dictionary<string, FormaCalculos> formas);
    }
}
