using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using static System.Net.Mime.MediaTypeNames;

namespace Prova
{
	public class Arrays
    {
        public static void ArrayOrder(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int aux = array[j];
                        array[j] = array[i];
                        array[i] = aux;
                    }
                }
            }
		}
    }
}
