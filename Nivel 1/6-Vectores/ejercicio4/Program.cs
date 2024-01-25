/*
 * Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro 
 * con los siguientes datos:
    - Número de Artículo (1 a 15)
    - Cantidad Vendida 

    Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.

    Se pide determinar e informar:
    a) El número de artículo que más se vendió en total.
    b) Los números de artículos que no registraron ventas.
    c) Cuantas unidades se vendieron del número de artículo 10.
 */

int nro_articulo, cantidad;
int[] total_cantidad_vendida = new int[15];

for (int i = 0; i < 15; i++)
{
    total_cantidad_vendida[i] = 0;
}

nro_articulo = 100;

while (nro_articulo != 0)
{
    Console.WriteLine("Ingrese numero de articulo");
    nro_articulo = int.Parse(Console.ReadLine());
    if (nro_articulo != 0)
    {
        Console.WriteLine("Ingrese cantidad vendida");
        cantidad = int.Parse(Console.ReadLine());
        total_cantidad_vendida[nro_articulo - 1] += cantidad;
    }
}

int mas_vendido = total_cantidad_vendida[0];
int nro_mas_vendido = 1;

for (int i = 1; i < 15; i++)
{
    if (total_cantidad_vendida[i] > mas_vendido)
    {
        mas_vendido = total_cantidad_vendida[i];
        nro_mas_vendido = i + 1;
    }
}

Console.WriteLine("El articulo mas vendido fue el numero " + nro_mas_vendido + " con " + mas_vendido + " ventas.");

bool flag = false;

Console.WriteLine("Articulos que no registraron ventas");

for (int i = 0; i < 15; i++)
{

    if (total_cantidad_vendida[i] == 0)
    {
        Console.WriteLine(i + 1);
        flag = true;
    }
}

if (!flag) { Console.WriteLine("Todos los articulos registraron ventas."); }

Console.WriteLine("El articulo numero 10 registro " + total_cantidad_vendida[9] + " ventas.");

Console.ReadLine();