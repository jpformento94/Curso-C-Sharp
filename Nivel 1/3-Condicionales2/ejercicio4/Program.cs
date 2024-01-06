/*
 * Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de 
 * los dos primeros es mayor al producto del segundo con el tercero.
 */

int n1, n2, n3, suma, producto;

Console.WriteLine("Ingrese numero 1");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese numero 2");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese numero 3");
n3 = int.Parse(Console.ReadLine());

suma = n1 + n2;

producto = n2 * n3;

if (suma > producto)
{
    Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero.");
}
else
{
    Console.WriteLine("La suma de los dos primeros no es mayor al producto del segundo con el tercero.");
}

Console.ReadLine();