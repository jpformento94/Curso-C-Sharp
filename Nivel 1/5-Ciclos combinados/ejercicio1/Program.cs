/*
 * Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla 
 * cuántos de esos números son primos.
 */

int n = 0;
int c = 0;

for (int i = 1; i < 11; i++)
{
    Console.WriteLine("Ingrese numero" + i);
    n = int.Parse(Console.ReadLine());

    for (int j = 1; j <= n; j++)
    {
        if ((n % j) == 0)
        {
            c++;
        }
    }

    if (c == 2)
    {
        Console.WriteLine("El numero " + n + " es primo.");
    }

    c = 0;
}

Console.ReadLine();