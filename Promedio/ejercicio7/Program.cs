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
