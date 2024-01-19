/*
 * Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares 
 * y el mínimo de los números impares.
 */

int n = 0;
int mayor_par = 0;
int menor_impar = 0;
bool flag_par = false;
bool flag_impar = false;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese un numero");
    n = int.Parse(Console.ReadLine());

    if ((n % 2) == 0)
    {
        if (flag_par == false)
        {
            mayor_par = n;
            flag_par = true;
        }
        else
        {
            if (n > mayor_par) { mayor_par = n; }
        }
    }
    else
    {
        if (flag_impar == false)
        {
            menor_impar = n;
            flag_impar = true;
        }
        else
        {
            if (n < menor_impar) { menor_impar = n; }
        }
    }
}

Console.WriteLine("El mayor de los pares es " + mayor_par);
Console.WriteLine("El menor de los impares es " + menor_impar);
Console.ReadLine();