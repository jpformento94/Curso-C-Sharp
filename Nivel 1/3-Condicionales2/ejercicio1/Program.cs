/*
 * Hacer un programa que solicite el ingreso de dos números y luego calcular:

    La resta si el primero es mayor que el segundo.
    La suma si son iguales.
    El producto si el primero es menor.

   Se deberá emitir un cartel por pantalla con el resultado correspondiente.

 */

int n1, n2, resultado;

resultado = 0;

Console.WriteLine("Ingrese numero 1");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese numero 2");
n2 = int.Parse(Console.ReadLine());

if (n1 == n2)
{
    resultado = n1 + n2;
    Console.WriteLine("Son iguales " + n1 + " + " + n2 + " = " + resultado);
}
else
{
    if (n1 > n2)
    {
        resultado = n1 - n2;
        Console.WriteLine("El primero es mayor " + n1 + " - " + n2 + " = " + resultado);
    }
    else
    {
        resultado = n1 * n2;
        Console.WriteLine("El primero es menor " + n1 + " * " + n2 + " = " + resultado);
    }
}

Console.ReadLine();