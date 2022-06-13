// See https://aka.ms/new-console-template for more information
/*Escribir un programa que haga lo siguiente:

1) Borrar la pantalla.
2) Pedir el nombre de una persona.
3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
4) Preguntar si se quiere continuar.
5) Si la respuesta es "S" repetir desde el punto 1.
6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".
*/

//Este caso lo hice de tal forma que termine solo cuando se ingresa una N
string continuarCondicion;
do
{
    Console.Clear();

    Console.WriteLine("Por favor ingrese su nombre ");
    string nombreIngresado = Console.ReadLine();

    Console.WriteLine($"Hola  {nombreIngresado}!");
    do
    {
        Console.WriteLine("Quiere continuar? (S/N)");
        continuarCondicion = Console.ReadLine().ToUpper();
    } while (continuarCondicion != "S" && continuarCondicion != "N");


    if (continuarCondicion == "N")
    {
        Console.WriteLine("Programa finalizado correctamente");
    }
}while (continuarCondicion != "N");