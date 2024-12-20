﻿using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Contracts;
using CodingChallenge.Data.Classes.Formas;
using CodingChallenge.Data.Classes.Idiomas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        private IGeneradorDeReporte _generadorDeReporte;
        private Idioma _idioma;

        [SetUp]
        public void Initialize()
        {
            _idioma = new Castellano();
            _generadorDeReporte = new GeneradorDeReporte(_idioma);
        }

        [TestCase]
        public void TestResumenListaVacia()
        {
            //Arrange
            List<Forma> listaVacia = new List<Forma>();

            //Action
            var resumen = _generadorDeReporte.Imprimir(listaVacia);

            //Assert
            Assert.AreEqual(resumen, "<h1>Lista vacía de formas!</h1>");
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<Forma> {new Cuadrado(5)};
            var idioma = new Castellano();

            var resumen = _generadorDeReporte.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 formas Perímetro 20 Área 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<Forma> 
            { 
                new Cuadrado(5), 
                new Cuadrado(1),
                new Cuadrado(3) 
            };

            var resumen = _generadorDeReporte.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Cuadrados | Área 35 | Perímetro 36 <br/>TOTAL:<br/>3 formas Perímetro 36 Área 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
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
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13.01 | Perímetro 18.06 <br/>3 Triángulos | Área 49.64 | Perímetro 51.6 <br/>TOTAL:<br/>7 formas Perímetro 97.66 Área 91.65",
                resumen);
        }
    }
}
