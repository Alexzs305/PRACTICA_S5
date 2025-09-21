precio = float(input("Ingrese el precio del producto: "))
codigo = int(input("Ingrese el codigo del producto (1) Estudiante, (2) Empleado, (3) Cliente frecuente: "))

descuento = 0
precio_final = 0
descuento_adicional = 0

if codigo == 1:
    descuento = precio * 0.10
elif codigo == 2:
    descuento = precio * 0.15
elif codigo == 3:
    descuento = precio * 0.20

precio_final = precio - descuento

if precio > 500:
    descuento_adicional = precio_final * 0.05
    precio_final = precio_final - descuento_adicional

print(f"El precio final es : {precio_final:.2f}")

