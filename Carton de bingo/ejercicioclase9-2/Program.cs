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