/*
 * Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
 * Para ello existe la siguiente escala de precios:

                    i5 (1)      i7 (2)	    i9 (3)
        8 RAM  (1)  USD 800	    USD 900	    USD 1200
        16 RAM (2)  USD 900	    USD 1000	USD 1400
        32 RAM (3)  USD 1000	USD 1400	USD 2000

    Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar 
    a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. Hacer un programa que solicite 
    la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no 
    (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la 
    máquina seleccionada.
*/

int procesador, memoria, disco, precio;

precio = 0;

Console.WriteLine("Procesadores: i5 (1)     i7 (2)     i9 (3)\r\n" +
                  "Memoria RAM:  8 GB (1)   16 GB (2)  32 GB (3)");

Console.WriteLine("Seleccione procesador (1, 2, 3)");
procesador = int.Parse(Console.ReadLine());

Console.WriteLine("Seleccione memoria (1, 2, 3)");
memoria = int.Parse(Console.ReadLine());

Console.WriteLine("Agregar disco 1 TB? (0=NO, 1=SI)");
disco = int.Parse(Console.ReadLine());

switch (procesador)
{
    case 1:
        switch (memoria)
        {
            case 1:
                precio = 800;
                break;

            case 2:
                precio = 900;
                break;

            case 3:
                precio = 1000;
                break;

            default:
                break;
        }
        break;

    case 2:
        switch (memoria)
        {
            case 1:
                precio = 900;
                break;

            case 2:
                precio = 1000;
                break;

            case 3:
                precio = 1400;
                break;

            default:
                break;
        }
        break;

    case 3:
        switch (memoria)
        {
            case 1:
                precio = 1200;
                break;

            case 2:
                precio = 1400;
                break;

            case 3:
                precio = 2000;
                break;

            default:
                break;
        }
        break;

    default:
        break;
}

if ((precio !=0) && (disco == 1))
{
    precio = precio + 300;
}
Console.WriteLine("El precio final es " + precio);
Console.ReadLine();