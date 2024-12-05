using System;
using Prova;

namespace Exercici1
{
    public class Program
    {
        public static void Main()
        {
            const string InsertaValor = "Inserta el valor que vulguis buscar a l'array:";
            const string Error = "El valor insertat ha de ser un numero enter";
            const string Trobat = "El teu numero si esta a l'Array";
            const string NoTrobat = "El teu numero no esta a l'Array";
            const string ErrorArray = "La longitud del array es invalida";
            int numUser;
            int resultat;
            int[] arrayBuscar = { 10, -4, 6, 4, 8, 13, 2, -4 };
            SecondSort.Order(arrayBuscar, 0, arrayBuscar.Length - 1);
            Console.WriteLine(InsertaValor);
            try
            {
                numUser = int.Parse(Console.ReadLine());
                resultat = SearchClass.BinarySearch(arrayBuscar, 0, arrayBuscar.Length - 1, numUser);
                if (resultat == -1)
                {
                    Console.WriteLine(NoTrobat);
                }
                else
                {
                    Console.WriteLine(Trobat);
                }
            }
            catch (FormatException) { 
                Console.WriteLine(Error);
            }
        }
    }
}