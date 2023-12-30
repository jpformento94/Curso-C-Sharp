/* Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 
 * más una comisión del 5% sobre el total facturado por cada empleado. 
 * Hacer un programa para ingresar el total facturado por un empleado y que luego calcule 
 * y emita por pantalla el sueldo total a cobrar por el mismo.*/

float sueldo = 15000;
float facturado = 0;
const float comision = 0.05F;

Console.WriteLine("Ingrese el total facturado por el empleado: ");
facturado = float.Parse(Console.ReadLine());

sueldo = sueldo + (facturado * comision);

Console.WriteLine("El sueldo es de: " + sueldo);
Console.ReadLine();