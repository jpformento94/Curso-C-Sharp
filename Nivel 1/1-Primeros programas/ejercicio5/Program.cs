/*
 * Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno 
 * y luego calcule y emita por pantalla el promedio final.
 */

float n1, n2, n3, promedio;

Console.WriteLine("Nota 1: ");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Nota 2: ");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Nota 3: ");
n3 = float.Parse(Console.ReadLine());

promedio = (n1 + n2 + n3) / 3;

Console.WriteLine("Notas: " + n1 + " " + n2 + " " + n3);
Console.WriteLine("El promedio es " + promedio.ToString("0.00"));
Console.ReadKey();