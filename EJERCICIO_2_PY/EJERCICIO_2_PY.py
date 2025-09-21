import math

nota = float(input("INGRESE SU NOTA (0-20): "))

if nota >= 0 and nota <= 10: 
    print("Desaprobado")
elif nota >= 11 and nota <= 13:
    print("Regular")
elif nota >=14 and nota <= 17:
    print("Bueno")
elif nota >= 18 and nota <=20:
    print("Excelente")
else:
    print("NOTA NO VALIDA")

if nota >= 14 and nota % 2 == 0:
    print("Buen desempeno con nota par")
if nota % 2 != 0 and nota < 11:
    print("Necesita reforzar")

raiz_cuadrada = math.sqrt(nota)
potencia_cubo = math.pow(nota, 3)

print("La raiz cuadrada de la nota es: ", raiz_cuadrada)
print("La potencia al cubo de la nota es: ", potencia_cubo)
