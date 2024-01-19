/*
 *  Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas 
 *  personas mayores a 18 años. 
 */

int n = 0;
int c = 0;
float promedio = 0;

for (int i = 1; i < 21; i++)
{
    Console.WriteLine("Ingrese edad " + i);
    n = int.Parse(Console.ReadLine());
    if (n >= 18)
    {
        promedio += n;
        c++;
    }
}

promedio = promedio / c;
Console.WriteLine("El promedio es " + promedio);
Console.ReadLine();