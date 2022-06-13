Console.WriteLine("Ingrese la longitud del vector");


int longitud = int.Parse(Console.ReadLine());
int[] vector = new int[longitud];
Random random = new Random();
for (int i = 0; i < longitud; i++)
{
    vector[i] = random.Next(100);
}
Console.WriteLine();  
Console.WriteLine("El vector es : ");

foreach (int a in vector)
{
    Console.Write(a + " ");
}

int aux = 0;
int j = vector.Length-1;
for (int i = 0; i <=j; i++)
{
    aux=vector[i];
    vector[i] = vector[j];
    vector[j] = aux;
    j--;
}
Console.WriteLine();
Console.WriteLine("El vector invertido es : ");

foreach (int a in vector)
{
    Console.Write(a + " ");
}
