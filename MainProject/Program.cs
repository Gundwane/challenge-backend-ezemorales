using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Idiomas;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var cuadrados = new List<Forma>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };
var cuadradoss = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 1),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 3)
            };
Idioma idioma = new Castellano();
var reporte = new GeneradorDeReporte(idioma);
var stringRes = reporte.Imprimir(cuadrados);

var res = FormaGeometrica.Imprimir(cuadradoss, 1);

Console.WriteLine($"{res.ToString()}");