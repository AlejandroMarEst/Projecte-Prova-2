# Exercici 4
## A partir d'una màquina senzilla que pot executar 4 operacions (2 punts):
CMP -> 00 MOV-> 01 ADD -> 10  BEQ -> 11

Tradueix a llenguatge de baix nivell les següents instruccions, indicant la instrucció sencera (de 16 bits) en format binari que ha d’executar la màquina:
- CMP 2F, 35 = 0001011110110100

	2F 2x16=32 (F)15x1=15 32+15 = 47/2 = 23(r=1)/2=11(r=1)/2=5(r=1)/2=2(r=1)/2=(r=0)1 = 101111
	
	35 3x16=48 5x1=5 48+5 = 53/2=26(r=0)/2=13(r=0)/2=6(r=1)/2=3(r=0)/2=1(r=1) = 110100
- MOV AB, 74 = 01101010111110100

	AB (A)10x16=160 + (B)11x1=11 = 171/2=85(r=1)/2=42(r=1)/2=21(r=0)/2=10(r=1)/2=5(r=0)/2=2(r=1)/2=(r=0)1 = 10101011

	74 7x16=112 + 4 = 116/2=58(r=0)/2=29(r=0)/2=14(r=1)/2=7(r=0)/2=3(r=1)/2=(r=1)1 = 1110100
- ADD 12, 43 ->
- MOV A8, 66 ->

Important!! Totes les adreces de memòria estan en base hexadecimal.
