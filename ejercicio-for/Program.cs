/*
 Ejercicio 3 - For

Escribe un programa que realice estos pasos:
Reciba 3 datos: ancho, alto, relleno o no
Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.
 
 En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

 */

Console.WriteLine("Coloca el alto");
int alto = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Coloca el ancho");
int ancho = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < ancho; i++)
{
    Console.Write("*");
}

Console.WriteLine();

for (int i = 0; i < ancho - 2; i++)
{
    Console.Write("*");

    for (int j = 0; j < ancho - 2; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

for (int i = 0; i < ancho; i++)
{
    Console.Write("*");
}

Console.WriteLine();
    
