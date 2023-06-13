/*Ejercicio 1 - While

Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. Es decir, un programa que presente para el 1:

1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10*/


//Inicio del código

Console.WriteLine("Coloca el numero que deseas conocer su tabla de multiplicación");
int i = 1;
int mult = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("La tabla de multiplicar es:");

while (i <= 10)
{

    int result = mult * i;
    Console.WriteLine($"{i} x {mult} = {result}" );
        i++;    
}

