/*
 * Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” 
 * que reciba un número por valor y una variable por referencia. Que analice el número y 
 * escriba la variable recibida por referencia con:

    a. 1 si el número es positivo.
    b. -1 si el número es negativo.
    c. 0 si el número es cero.
 */


static void positivoNegativoCero(ref int referencia, int valor)
{
    if (valor > 0)
    {
        referencia = 1;
    }
    else
    {
        if (valor < 0)
        {
            referencia = -1;
        }
        else
        {
            referencia = 0;
        }
    }
}



int x = 10;
int y = 10;

positivoNegativoCero(ref x, y);
Console.WriteLine("Variable por referencia " + x);
Console.WriteLine("Variable por valor " + y);
Console.ReadLine();