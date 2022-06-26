/*
 Diseñe la siguiente jerarquía para las clases:

Cuadrilátero.
Trapecio.
Rectángulo.
Cuadrado.

Use la clase Cuadrilátero como la clase base de la jerarquía, que debe ser abstracta.

Los datos privados de la clase base deben ser las coordenadas x-y de los cuatro vértices de la figura y debe contener un método abstracto para calcular el área.

Agregue un constructor a cada clase para inicializar sus datos e invoque el constructor de la clase base desde el constructor de cada clase derivada.

Escriba un programa que instancie objetos de cada una de las clases y calcule el área correspondiente. Investigue las fórmulas para calcular el área de cada figura.
 
 */
using Cuadrilateros.Models;

Console.WriteLine("Bienvenido a cuadrilates, que tipo de cuadrilatero prefiere calcular el area?");
Console.WriteLine("1_ Trapecio");
Console.WriteLine("2_ Cuadrado");
Console.WriteLine("3_ Rectangulo");
int opcion = int.Parse(Console.ReadLine()); 
switch (opcion)
{
    case 1:
        var a = new Trapecio();
        a.CalculateArea();
        break;

    case 2:
        var b = new Cuadrado();
        b.CalculateArea();
        break;
    case 3:
        var c = new Rectangulo();
        c.CalculateArea();
        break;

    default:
        Console.WriteLine("Usted salio del programa");
        break;
}

