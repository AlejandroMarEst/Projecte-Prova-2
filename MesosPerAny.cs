using System;
using System.Reflection.Metadata.Ecma335;
using static System.Net.Mime.MediaTypeNames;

namespace Prova
{
	public class DataCheck
    {
        public static int DiaPerMesos(int mes, bool bisiesto)
        {
            bool mesos31;
            bool febrer;
            if (mes is 1 or 3 or 5 or 7 or 8 or 10 or 12)
            {
                mesos31 = true;
            } 
            else {mesos31 = false;}
            if (mes == 2 ? febrer = true : febrer = false);
            if (mes < 1 || mes > 12)
                {
                    if (mesos31)
                    {
                        return 31;
                    }
                    else if (febrer)
                    {
                        if (bisiesto) { return 29;}
                        else { return 28; }
                    }
                    else
                    {
                        return 30;
                    }
                }
            return 0;
		}
    }
}
