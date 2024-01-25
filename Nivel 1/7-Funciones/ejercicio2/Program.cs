/*
 * Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
 * Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
 */

int[] numeros = new int[20];

static int par(int n)
{
    int flag = 0;
    if ((n % 2) == 0)
    {
        flag = 1;
    }
    return flag;
}

static void cargarVector(ref int[] numeros)
{
    Random random = new Random();
    Console.WriteLine("Elementos del arreglo");
    for (int i = 0; i < numeros.Length; i++)
    {
        numeros[i] = random.Next(0, 99);
        Console.WriteLine(numeros[i]);
    }
}

static int contarPares(int[] numeros)
{
    int contador = 0;
    for (int i = 0; i < numeros.Length; i++)
    {
        if (par(numeros[i]) == 1)
        {
            contador++;
        }
    }
    return contador;
}

cargarVector(ref numeros);
Console.WriteLine("Hay " + contarPares(numeros) + " numeros pares.");
Console.ReadLine();