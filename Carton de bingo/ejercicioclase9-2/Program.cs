/*Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

1)    Cartón de 3 filas por 9 columnas
2)    El cartón debe tener 15 números y 12 espacios en blanco
3)    Cada fila debe tener 5 números
4)    Cada columna debe tener 1 o 2 números
5)    Ningún número puede repetirse
6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
7)    Mostrar el carton por pantalla*/

int[,] matriz = new int[3, 9];
int lengthFila = matriz.GetUpperBound(0) + 1;
int lengthColumna = matriz.GetUpperBound(1) + 1;

Random rand = new Random();

int max = 10;
int min = 1;
bool seRepite = false;

//creo la matriz para que no se igualen los numeros
for (int j = 0; j < lengthColumna; j++)
{

    for (int i = 0; i < lengthFila; i++)
    {
        do
        {
            matriz[i, j] = rand.Next(min, max);
            for (int k = 0; k < i; k++)
            {

                if (matriz[k, j] == matriz[i, j])
                {
                    seRepite = true;
                    matriz[i, j] = rand.Next(min, max);
                }
                else seRepite = false;

            }
        } while (seRepite);
    }

    min += 10;
    max += 10;

}

//aca voy a seleccionar 2 columnas por cada fila donde van a ser cero
Random columnasConVacio = new Random();
int columnaRandom = 0;
int contador = 0;
bool columnaSiTieneVacio = false;
for (int i = 0; i < lengthFila; i++)
{
    contador = 0;
    while (contador < 4)
    {
        columnaRandom = columnasConVacio.Next(0, 9);
        
        if (i > 0 && columnaRandom<lengthColumna) 
        {
            if(matriz[i-1, columnaRandom] == 0)
            {
                columnaRandom = columnasConVacio.Next(0, 9);
            }
        }
        matriz[i, columnaRandom] = 0;
        contador++;

    }

}

for (int i = 0; i < lengthFila; i++)
{
    Console.WriteLine();
    for (int j = 0; j < lengthColumna; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
}