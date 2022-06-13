/*Escribe un programa que:

1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

Recuerden que no nos deben adjuntar archivos comprimidos ni imagenes.
Pueden adjuntarnos el archivo .cs, o el codigo como texto.*/


//Pido 10 numeros al usuario
int[] vector = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Ingrese el {i+1} nro: ");
    vector[i]= int.Parse(Console.ReadLine());
}
Console.WriteLine("El vector es :");
Console.Write("[");
for (int i = 0; i < vector.Length; i++)
{
    Console.Write($"{vector[i]} ");
}
Console.Write("]");

double suma = 0;
for (int i = 0; i < vector.Length; i++)
{
    suma += vector[i];
}
Console.WriteLine($"La suma de todos sus componentes es : {suma}");

int mayor = int.MinValue;
for(int i = 0; i < vector.Length; i++)
{
    if (vector[i] > mayor)
    {
        mayor = vector[i];
    }
}
Console.WriteLine($"El mayor numero del vector es {mayor}");
int menor = int.MaxValue;
for (int i = 0; i < vector.Length; i++)
{
    if (vector[i] <menor)
    {
        menor = vector[i];
    }
}
Console.WriteLine($"El menor numero del vector es {menor}");

double promedio = suma/(vector.Length);
Console.WriteLine($"El promedio de sus componentes es {promedio}");
