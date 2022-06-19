/*Ejercicio de cartas españolas orientado a objetos:

Cada carta tiene un número entre 1 y 12 (el 8 y el 9 no los incluimos) y un palo (espadas, bastos, oros y copas)
La baraja estará compuesta por un conjunto de cartas, 40 exactamente.

Las operaciones que podrá realizar la baraja son:

Barajar():
  Cambia de posición todas las cartas aleatoriamente.

SiguienteCarta():
  Devuelve la siguiente carta que está en la baraja, cuando no haya más o se haya llegado al final, se indica al usuario que no hay más cartas.

CartasDisponibles():
  Indica el número de cartas que aún puede repartir

DarCartas(int cantidad):
  Dado un número de cartas que nos pidan, le devolveremos ese número de cartas (piensa que puedes devolver). En caso de que haya menos cartas que las pedidas, no devolveremos nada pero debemos indicárselo al usuario.

CartasMonton():
  Mostramos aquellas cartas que ya han salido, si no ha salido ninguna indicárselo al usuario.

MostrarBaraja():
  Muestra todas las cartas hasta el final. Es decir, si se saca una carta y luego se llama al método, este no mostrara esa primera carta.


Escribir un programa que dentro de un bucle vaya mostrando las opciones que querramos, por ejemplo

1 - Barajar
2 - Mostrar siguiente carta
3 - Mostrar cartas disponibles
4 - Dar cartas
5 - Mostrar cartas del monton
6 - Mostrar baraja
7 - Salir*/
using CartasEspaniolas;

bool jugando = true;
Baraja b1 = new Baraja();
while (jugando)
{
    Console.Clear();
    Console.WriteLine("Usted tiene un Naipe de cartas espaniolas");
    Console.WriteLine("Seleccione que desea hacer con el naipe");
    Console.WriteLine("0 - Mostrar Baraja");
    Console.WriteLine("1 - barajar");
    Console.WriteLine("2 - Sacar la primera carta y acumularla en el monton");
    Console.WriteLine("3 - Contar cartas disponibles");
    Console.WriteLine("4 - Sacar mas de una carta y acumular en el monton. Indicando la cantidad de cartas");
    Console.WriteLine("5 - Mostrar el monton (las cartas que ya se sacaron)");
    Console.WriteLine("6 - Dejar de jugar");
    int opcion = int.Parse(Console.ReadLine());
    

    switch (opcion)
    {
        case 0:
            Console.Clear();
            b1.MostrarBaraja();
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            break;
        case 1:
            Console.Clear();
            b1.Barajar(b1.Cartas);
            Console.WriteLine("Las cartas se encuentran mezcladas");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            break;
        case 2:
            Console.Clear();
            b1.SacarCarta();
            Console.WriteLine("Usted Saco una carta");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();

            break;
        case 3:
            b1.Barajar(b1.Cartas);
            break;
        case 4:
            b1.Barajar(b1.Cartas);
            break;
        case 5:
            Console.Clear();
            b1.MostrarMonton();
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            break;
        case 6:
            jugando = false;
        break;
        default:
            Console.WriteLine("Eligio cualquier cosa");
            break;
    }

}





