//Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

//BilletesDe10
//BilletesDe20
//BilletesDe50
//BilletesDe100
//BilletesDe200
//BilletesDe500
//BilletesDe1000

//Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

//Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
//Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)
using Billeteras;

Billetera b1 = new Billetera()
{
    BilletesDe10 = 1,
    BilletesDe20 = 1,
    BilletesDe100 = 1,
    BilletesDe500 = 1,
    BilletesDe50 = 1,
    BilletesDe1000 = 1,

};

Billetera b2 = new Billetera()
{
    BilletesDe10 = 1,
    BilletesDe20 = 1,
    BilletesDe100 = 1,
    BilletesDe500 = 1,
    BilletesDe50 = 1,
    BilletesDe1000 = 1,

};

Console.WriteLine("El total de billetera 1 es "+ b1.Total());
Console.WriteLine("El total de la billetera 2 es: " + b2.Total());

Billetera b3 = new Billetera().Combinar(b1, b2);

Console.WriteLine("El ttoal de la nueva billetera es: " + b3.Total());
Console.WriteLine("El total de la billetera 1 es: " + b1.Total());
Console.WriteLine("El total de la billetera 2 es: " + b2.Total());


