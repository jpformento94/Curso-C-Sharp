/*
 * Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos 
 * se encuentran ordenados de forma decreciente .
 */

int n1, n2, n3, n4;

bool flag = true;

Console.WriteLine("Ingrese numero 1");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese numero 2");
n2 = int.Parse(Console.ReadLine());

if (n2 > n1) flag = false;

Console.WriteLine("Ingrese numero 3");
n3 = int.Parse(Console.ReadLine());

if (n3 > n2) flag = false;

Console.WriteLine("Ingrese numero 4");
n4 = int.Parse(Console.ReadLine());

if (n4 > n3) flag = false;

if (flag)
{
    Console.WriteLine("Estan ordenados de forma decreciente");
}
else
{
    Console.WriteLine("No estan ordenados de forma decreciente");
}

Console.ReadLine();