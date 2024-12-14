using CodingChallenge.Data.Classes.Formas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Contracts
{
    public interface IGeneradorDeReporte
    {
        string Imprimir(List<Forma> formas);
    }
}
