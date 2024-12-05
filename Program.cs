using System;
using Prova;

namespace Exercici1
{
    public class Program
    {
        public static void Main()
        {
            const string InsertNum = "Inserta un valor";
            const string InsertNumBuscar = "Inserta el valor que vols buscar";
            const string BusquedaPositiva = "Si esta a l'array";
            const string BusquedaNegativa = "No esta a l'array";
            const string Error = "Inserta nums enters";
            int[] arrayNums = new int[20];
            int numBuscar;
            int resultat;
            try
            {
                for (int i = 0; i < arrayNums.Length; i++)
                {
                    Console.WriteLine(InsertNum);
                    arrayNums[i] = int.Parse(Console.ReadLine());
                }
                Arrays.ArrayOrder(arrayNums);
                Console.WriteLine(InsertNumBuscar);
                numBuscar = int.Parse(Console.ReadLine());
                resultat = Search.ArraySearch(arrayNums, 0, arrayNums.Length -1, numBuscar);
                if (resultat == -1)
                {
                    Console.WriteLine(BusquedaNegativa);
                }
                else { 
                    Console.WriteLine(BusquedaPositiva);
                }
            }
            catch (FormatException) {
                Console.WriteLine(Error);
            }
        }
    }
}