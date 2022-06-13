// See https://aka.ms/new-console-template for more information



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