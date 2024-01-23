/*
 * Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
 * Se pide determinar e informar:
    El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
    Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
*/

int n = 0;
int minimo = 0;
int total_de_numeros;
int total_impares;
int grupo = 0;
float porcentaje_impares = 0;
float porcentaje_maximo = 0;
bool bandera_ordenados;
int contador_grupos_ordenados = 0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Ingrese un numero para cargar en la lista");
    Console.WriteLine("Ingrese 0 para terminar la carga de la lista");
    n = int.Parse(Console.ReadLine());

    minimo = n;

    bandera_ordenados = true;
    total_de_numeros = 0;
    total_impares = 0;

    while (n != 0)
    {
        total_de_numeros++;
        if ((n % 2) != 0)
        {
            total_impares++;
        }

        if ((n <= minimo) && (bandera_ordenados))
        {
            minimo = n;
        }
        else
        {
            bandera_ordenados = false;
        }

        n = int.Parse(Console.ReadLine());
    }
    porcentaje_impares = (total_impares * 100) / total_de_numeros;

    if (porcentaje_impares > porcentaje_maximo)
    {
        porcentaje_maximo = porcentaje_impares;
        grupo = i;
    }

    if (bandera_ordenados)
    {
        Console.WriteLine("El grupo " + i + " esta ordenado de mayor a menor.");
        contador_grupos_ordenados++;
    }
}

if (porcentaje_maximo == 0)
{
    Console.WriteLine("No hay impares");
}
else
{
    Console.WriteLine("El grupo con mayor porcentaje de impares es el " + grupo + " con " + porcentaje_maximo + "%.");
}

Console.WriteLine("Hay " + contador_grupos_ordenados + " grupos ordenados de mayor a menor.");

Console.ReadLine();