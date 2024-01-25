/*
 * Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o 
 * cero si no lo es. Hacer un programa para ingresar números. 
 * El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta 
 * sólo los números primos.
 */


using System.ComponentModel;

int[] numeros = new int[20];


static int primo(int n)
{
    int flag = 0;
    int contador = 0;

    for (int i = 1; i <= n; i++)
    {
        if ((n % i) == 0)
        {
            contador++;
        }
    }

    if (contador == 2)
    {
        flag = 1;
    }
    return flag;
}

static float promedioPrimos(int[] numeros)
{
    float contador = 0;
    float acumulador = 0;
    float promedio = 0;

    for (int i = 0; i < numeros.Length; i++)
    {
        if (primo(numeros[i]) == 1)
        {
            acumulador += numeros[i];
            contador++;
        }
    }
    promedio = acumulador / contador;
    return promedio;
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

cargarVector(ref numeros);
Console.WriteLine($"El promedio de los numeros primos es {promedioPrimos(numeros).ToString("0.00")}");
Console.ReadLine();