/*
 * Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio 
 * si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente 
 * por 1 y por sí mismo.
 */

int n;
int c = 0;

Console.WriteLine("Ingrese un numero");
n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if ((n % i) == 0)
    {
        c++;
    }
}

if (c == 2)
{
    Console.WriteLine("El numero " + n + " es primo.");
}
else
{
    Console.WriteLine("El numero " + n + " no es primo.");
}

Console.ReadLine();