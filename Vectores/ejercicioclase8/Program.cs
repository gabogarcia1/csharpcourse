/*Crear un programa que cumpla con los siguientes pasos

1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios*/

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