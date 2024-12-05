using System;
using Prova;

namespace Exercici1
{
    public class Program
    {
        public static void Main()
        {
            const string IntrodueixData = "Introdueix el dia, mes i any";
            const string DataValida = "Aquesta data es valida";
            const string DataNoValida = "Aquesta data no es valida";
            int dia;
            int mes;
            int any;
            int diasPerMes;
            bool bisiesto;
            do {
                Console.WriteLine(IntrodueixData);
                dia = int.Parse(Console.ReadLine());
                mes = int.Parse(Console.ReadLine());
                any = int.Parse(Console.ReadLine());
            } while (dia < 1 || dia > 31);
            bisiesto = (any % 400 == 0) || ((any % 4 == 0) && (any % 100 != 0));
            diasPerMes = DataCheck.DiaPerMesos(mes, bisiesto);
            if (diasPerMes < dia)
            {
                Console.WriteLine(DataNoValida);
            }
            else
            {
                Console.WriteLine(DataValida);
            }
        }
    }
}