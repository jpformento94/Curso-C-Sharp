/*
 * Una casa de videojuegos otorga un descuento dependiendo del importe de la compra realizada 
 * según los siguientes valores:

    Si el importe es menor a ARS 1000, no hay descuento.
    Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
    Si el importe es ARS 5000 o más, aplica un descuento del 18%.

*/

float importe;

Console.WriteLine("Ingrese importe");

importe = float.Parse(Console.ReadLine());

if (importe < 1000)
{
    Console.WriteLine("No hay descuento, monto a pagar " + importe);
}
else
{
    if ((importe >= 1000) && (importe < 5000))
    {
        Console.WriteLine("Descuento del 10%, monto a pagar " + (importe * 0.90F));
    }
    else 
    { Console.WriteLine("Descuento del 18%, monto a pagar " + (importe * 0.82F)); }
}

Console.ReadLine();