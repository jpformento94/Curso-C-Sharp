/*
 * Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
  * El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado 
  * hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. 
  * 
  * Ejemplo:
    CADENA FUENTE: “La mar estaba serena"
    CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
    CADENA RESULTADO: “Li mir estibi sereni"
 */

string texto;
char letra_actual, letra_cambiar;

Console.WriteLine("Escribe un texto");
texto = Console.ReadLine();
Console.WriteLine("Ingrese la letra a cambiar");
letra_actual = char.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la letra nueva");
letra_cambiar = char.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine("Texto original");
Console.WriteLine(texto);

texto = texto.Replace(letra_actual, letra_cambiar);
Console.WriteLine("Texto cambiado");
Console.WriteLine(texto);
Console.ReadLine();