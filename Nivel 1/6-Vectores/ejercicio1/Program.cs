/*
 * Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
 * Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición 
 * dentro del vector.
 */

int maximo, posicion;

int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese un numero");
    numeros[i] = int.Parse(Console.ReadLine());
}

posicion = 0;
maximo = numeros[0];

for (int i = 1; i < 10; i++)
{
    if (numeros[i] > maximo)
    {
        maximo = numeros[i];
        posicion = i;
    }
}

Console.WriteLine("El maximo es " + maximo + " y esta en la posicion " +  posicion);
Console.ReadLine();