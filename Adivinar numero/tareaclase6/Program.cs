
//Genero numero secreto
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
Console.WriteLine($"El numero secreto es : {numeroSecreto}");
Console.WriteLine("Adivina nuestro numero secreto entre 1 y el 20. si lo haces en menos de 5 chances ganas un premio");
Console.WriteLine("El numero ya fue generado, que numero pensas que es?");
bool banderaGanaste = false;
int contador = 1; //Empiezo con uno para que cuente el primer intento


//Recibo valor
int numero = 0;
bool banderaNaN = false;
string valorRecibido;
do
{
    valorRecibido = Console.ReadLine();
    banderaNaN = !(Int32.TryParse(valorRecibido, out numero)); //si es un numero banderaNaN me da un valor falso y vuelve a pedirme otros
    if (banderaNaN)
        Console.WriteLine($"ERROR : El valor ingresado no es un numero : '{valorRecibido}' Por favor ingrese otro numero");
} while (banderaNaN);

Console.WriteLine($"El numero que elegiste es {numero}");

while (!banderaGanaste)
{
    if (numero < numeroSecreto)
    {
        Console.WriteLine($"El numero: {numero} que elegiste es menor al numero secreto ");
        //Vuelvo a recibir valor
        do
        {
            valorRecibido = Console.ReadLine();
            banderaNaN = !(Int32.TryParse(valorRecibido, out numero));
            if (banderaNaN)
                Console.WriteLine($"ERROR : El valor ingresado no es un numero : '{valorRecibido}' Por favor ingrese otro numero");
        } while (banderaNaN);
        contador++;
    }
    else if (numero == numeroSecreto)
    {
        Console.WriteLine($"GANASTE!!!!!! El numero {numero} que elegiste es el correcto!!! Despues de {contador} intentos");
        banderaGanaste = true;
        if (contador <= 5) Console.WriteLine("Lo hiciste en menos de 5 chances, pasa por caja a retirar tu premio");
        else Console.WriteLine("Mejor suerte en la proxima");

    }
    else
    {
        Console.WriteLine($"El numero {numero} que elegiste es mayor al numero secreto");
        do
        {
            valorRecibido = Console.ReadLine();
            banderaNaN = !(Int32.TryParse(valorRecibido, out numero));
            if (banderaNaN)
                Console.WriteLine($"ERROR : El valor ingresado no es un numero : '{valorRecibido}' Por favor ingrese otro numero");
        } while (banderaNaN);
        contador++;
    }
}



