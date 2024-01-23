/*
 * Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
 * El fin de la carga se notifica con un número negativo. 
 * Luego mostrar cuántos números tiene cada lista.
 */

int n, c;
int numero_grupo = 0;

do
{
    numero_grupo++;
    c = 0;
    Console.WriteLine("Ingrese un numero para cargar en la lista");
    Console.WriteLine("Ingrese 0 para terminar la carga de la lista");
    n = int.Parse(Console.ReadLine());
    while (n > 0)
    {
        c++;
        n = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("La cantidad del grupo " + numero_grupo + " es " + c);

} while (n >= 0);