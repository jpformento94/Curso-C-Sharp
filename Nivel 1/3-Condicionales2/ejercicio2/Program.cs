/*
 * Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros 
 * vendidos según la siguiente escala:

    Si vende menos de 100 litros, no hay descuento.
    Si vende entre 101 y 300 litros, el descuento es del 10%.
    Si vende entre 301 y 500 litros, el descuento es del 15%.
    Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

   Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de 
   litros vendidos y calcule y emita el importe con el descuento  aplicado..
 */

float litros, importe;

Console.WriteLine("Ingrese litros vendidos");
litros = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese importe de venta");
importe = int.Parse(Console.ReadLine());

if (litros <= 100)
{
    Console.WriteLine("No hay descuento, monto a pagar " + importe);
}
else
{
    if ((litros >= 101) && (litros <= 300))
    {
        importe = importe * 0.9F;
        Console.WriteLine("Descuento del 10%, importe a pagar " + importe);
    }
    else
    {
        if ((litros >= 301) && (litros <= 500))
        {
            importe = importe * 0.85F;
            Console.WriteLine("Descuento del 15%, importe a pagar " + importe);
        }
        else
        {
            importe = importe * 0.75F;
            Console.WriteLine("Descuento del 25%, importe a pagar " + importe);
        }
    }
}

Console.ReadLine();