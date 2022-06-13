//Primero genero la matriz y le doy valores
Console.WriteLine("Elegi la cantidad de filas : ");
int filas= int.Parse(Console.ReadLine());
Console.WriteLine("Elegi la cantidad de columnas : ");
int columna = int.Parse(Console.ReadLine());

int[,] array2D = new int[filas, columna];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columna; j++)
    {
        Console.WriteLine($"valor fila {i+1} , columa {j+1}");
        array2D[i, j] = int.Parse(Console.ReadLine());
    }
}

//Muestro la matriz
Console.WriteLine("Matriz: ");
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columna; j++)
    {
        Console.Write($"{array2D[i,j]} ");
    }
    Console.WriteLine();
}
double suma = 0;
double[] promedio = new double[columna];
//calculo el promedio de cada columna
for (int j = 0; j < columna; j++)
{
    suma = 0;

    for (int i = 0; i < filas; i++)
    {
        suma += array2D[i,j];
        
    }
    promedio[j]= suma/filas;
}
Console.WriteLine("Vector promedio");
Console.Write("[");
for (int i = 0; i < columna; i++)
{
    Console.Write($"{promedio[i]} ");
}
Console.Write("]");