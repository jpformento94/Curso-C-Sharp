/*
 *  Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla.
 *  Solo se debe emitir UN valor por pantalla. 
 */

int n = 0;
int mayor = 0;

for (int i = 1; i < 11; i++)
{
    Console.WriteLine("Ingrese numero " + i);
    n = int.Parse(Console.ReadLine());
    if (i == 1)
    {
        mayor = n;
    }
    else
    {
        if (n > mayor)
        {
            mayor = n;
        }
    }
}

Console.WriteLine("El mayor es " + mayor);
Console.ReadLine();