/*
    Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
*/

double n1, cubo;

Console.WriteLine("Cubo de un numero");
Console.WriteLine("Ingrese un numero: ");
n1 = int.Parse(Console.ReadLine());

cubo = Math.Pow(n1, 3);

Console.WriteLine(n1 + "^3 = " + cubo);
Console.ReadLine();
