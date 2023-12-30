/*
    Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades
     y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado 
     que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
*/


float km, vel, tiempo;

Console.WriteLine("Ingrese los km: ");
km = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la velocidad: ");
vel = float.Parse(Console.ReadLine());

tiempo = km / vel;

Console.WriteLine("El tiempo sera de " + tiempo.ToString("0.00") + " horas.");
Console.ReadLine();
