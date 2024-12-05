# Detalla el càlcul del mètode recursiu següent pels valors de num indicats, tal com hem fet a classe. Quina funcionalitat executa el mètode? (2 punts):
- num = 2

Es menor que 10 aixi que torna el num
RecMethod(num)
	RecMethod(2)
Retorna 2 i acaba

- num = 12

Es major que 12 aixi que es repeteix fins que dona la suma de les xifres de num
RecMethod(num) 
	RecMethod(12)
		RecMethod(3)
Retorna 3 i acaba

- Funcionalitat

Aquest metode agafa el numero que tu insertas i retorna el numero de les seves xifres.
(O directament el numero si es menor a 10)

´´´ C#
public static int RecMethod(int num)
{
	int total = 0;

	if (num < 10) return num;

	while (num > 0)
	{
    	    total += num % 10;
    	    num /= 10;
	}

	return RecMethod(total);
}
´´´