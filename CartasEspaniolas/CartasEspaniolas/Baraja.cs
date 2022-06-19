using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasEspaniolas
{
    internal class Baraja
    {
        //propiedad para generar la lista de cartas
        public List<string> Cartas { get; set; }
        public Stack<string> Monton { get; set; }

        //Connstructor que me genera la baraja entera
        public Baraja()
        {
            Cartas = new List<string>()
            {"1 de Copa","1 de oro","1 de Espada","1 de Basto",
            "2 de Copa","2 de oro","2 de Espada","2 de Basto",
            "3 de Copa","3 de oro","3 de Espada","3 de Basto",
            "4 de Copa","4 de oro","4 de Espada","4 de Basto",
            "5 de Copa","5 de oro","5 de Espada","5 de Basto",
            "6 de Copa","6 de oro","6 de Espada","6 de Basto",
            "7 de Copa","7 de oro","7 de Espada","7 de Basto",
            "10 de Copa","10 de oro","10 de Espada","10 de Basto",
            "11 de Copa","11 de oro","11 de Espada","11 de Basto",
            "12 de Copa","12 de oro","12 de Espada","12 de Basto",
            };
            Monton = new Stack<string>()
            { };
        }

        //Metodos
        public void Barajar(List<string> cartas)
        {
            List<string> cartasAux = new List<string>();

            Random rand = new Random();
            int aux=0;
            bool flag=true;
            List<int> auxList = new List<int>();
            for (int i = 0; i < cartas.Count; i++)
            {
               
                aux = rand.Next(0, 40);
                do
                {
                    flag = false;
                    for (int j = 0; j < auxList.Count; j++)
                    {
                        if (auxList[j] == aux)
                        {
                            flag = true;
                        }
                    }
                    if (flag)
                    {
                        aux = rand.Next(0, 40);
                       
                    }

                } while (flag);
                auxList.Add(aux);
                cartasAux.Add(cartas[aux]);
            }

            for (int i = 0; i < cartas.Count; i++)
            {
                cartas[i] = cartasAux[i];
            }

        }

        public void MostrarBaraja()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("Se muestra Baraja");
            foreach (var cart in Cartas)
            { Console.WriteLine(cart); }
            Console.WriteLine("============================================");

        }

        public void SacarCarta()
        {
            if (Cartas.Count<=1)
            {
                Console.WriteLine("Esta superando el limite de cartas que quedan en el naipe");
            }
            else
            {
                Monton.Push(Cartas[0]);
                Cartas.Remove(Cartas[0]);
            }
            
        }

        public void SacarCarta(int numero)
        {
            if (numero >= Cartas.Count)
            {
                Console.WriteLine("Esta superando el limite de cartas que quedan en el naipe");
            }
            else
            {
                for (int i = 0; i < numero; i++)
                {
                    Monton.Push(Cartas[0]);
                    Cartas.Remove(Cartas[0]);
                }
                Console.WriteLine($"Usted Saco {numero} cartas");
            }

        }
        public void MostrarMonton()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("Se muestra Monton");
            foreach (var cart in Monton)
            { Console.WriteLine(cart); }
            Console.WriteLine("============================================");
        }
        
    }
}
