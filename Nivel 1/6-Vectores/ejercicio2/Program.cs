/*
 * Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
 * Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores 
 * que son mayores al promedio.
 */

float promedio = 0;

int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese numero");
    numeros[i] = int.Parse(Console.ReadLine());
    promedio = promedio + numeros[i];
}

promedio = promedio / 10;
Console.WriteLine("El promedio es " + promedio);
Console.WriteLine("Los numeros mayores al promedio son");

for (int i = 0; i < 10; i++)
{
    if (numeros[i] > promedio)
    {
        Console.WriteLine(numeros[i]);
    }
}

Console.ReadLine();