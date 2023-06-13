
/*Ejercicio 2 - Do while
Escribe un programa que realice estos pasos:
Reciba al menos un número por consola OK
Determine si el número es positivo o negativo OK
Presente un contador para cada tipo (positivo y negativo).
Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. Tienes completa libertad para elegir el formato de la salida.
*/


Console.WriteLine("Conoce si el número es positivo o negativo");
int num = Convert.ToInt32(Console.ReadLine());
int contador = 0;

if (num > 0)
{
    Console.WriteLine("El numero es positivo");
    do
    {
        Console.WriteLine(contador);
        contador++;

    } while (num > contador);
}
else if (num < 0)
{
    Console.WriteLine("El numero es negativo");
    do
    {
        Console.WriteLine(contador);
        contador--;

    } while (num < contador);
}
else
{
    Console.WriteLine("El numero es igual a cero");
        
};



