using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using static System.Net.Mime.MediaTypeNames;

namespace Prova
{
	public class Search
    {
        public static int ArraySearch(int[] array, int first, int last, int key)
        {
            if (last >= first)
            {
                int mid = first + (last - first) / 2;
                if (array[mid] == key)
                {
                    return mid;
                }
                if (array[mid] > key)
                {
                    return ArraySearch(array, first, mid - 1, key);
                }
                else
                {
                    return ArraySearch(array, mid + 1, last, key);
                }
            }
            return -1;
        }
    }
}
