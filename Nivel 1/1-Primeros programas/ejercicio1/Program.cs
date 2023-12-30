/*
    Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
*/

int n1, n2;

Console.WriteLine("Ingrese el primer numero: ");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero: ");
n2 = int.Parse(Console.ReadLine());

int suma = n1 + n2;

Console.WriteLine(n1 + " + " + n2 + " = " + suma);
Console.ReadLine();
