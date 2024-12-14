using CodingChallenge.Data.Classes.Contracts;
using CodingChallenge.Data.Classes.Idiomas;
using CodingChallenge.Data.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Assert = NUnit.Framework.Assert;
using CodingChallenge.Data.Classes.Formas;

namespace CodingChallenge.Data.Tests
{
    /// <summary>
    /// Summary description for DataTestEnglish
    /// </summary>
    [TestFixture]
    public class DataTestEnglish
    {
        private IGeneradorDeReporte _generadorDeReporte;
        private Idioma _idioma;

        [SetUp]
        public void Initialize()
        {
            _idioma = new English();
            _generadorDeReporte = new GeneradorDeReporte(_idioma);
        }

        [TestCase]
        public void TestResumenListaVaciaEnIngles()
        {
            //Arrange
            List<Forma> listaVacia = new List<Forma>();

            //Action
            var resumen = _generadorDeReporte.Imprimir(listaVacia);

            //Assert
            Assert.AreEqual(resumen, "<h1>Empty list of shapes!</h1>");
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoEnIngles()
        {
            var cuadrados = new List<Forma> { new Cuadrado(5) };

            var resumen = _generadorDeReporte.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 shapes Perimeter 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadradosEnIngles()
        {
            var cuadrados = new List<Forma>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = _generadorDeReporte.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnIngles()
        {
            var formas = new List<Forma>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = _generadorDeReporte.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                resumen);
        }
    }
}
