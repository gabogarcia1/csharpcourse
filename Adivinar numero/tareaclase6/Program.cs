/*1) Generar un número secreto
aleatorio con la siguiente instruccion:

// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

2) Pedir al usuario que ingrese un número y que
intente adivinar el número que eligió la computadora.

3) Si el numero ingresado por el usuario es mayor
al número secreto, avisarle que es muy grande y que intente de nuevo y que
vuelva al paso 2.

4) Si el numero ingresado es menor al número
secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

5) Si el número ingresado coincide con el número
secreto, sacar el siguiente mensaje:

"Felicitaciones, has adivinado el número
secreto que era:  [numeroSecreto]"
"Lo has logrado en [n] intentos!!"

Y finalizar el programa.

Nota:
Obviamente hay que hacer un bucle y crear un contador de intentos.
Sean honestos con ustedes mismos y usen sus propias neuronas para resolver el problema, y aunque no lo terminen lo importante es intentarlo.*/


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



