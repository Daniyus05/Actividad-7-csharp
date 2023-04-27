// See https://aka.ms/new-console-template for more information
int numeroCorrecto = new Random().Next(1, 16); // Genera un número aleatorio entre 1 y 15
int intentosRestantes = 3;

while (intentosRestantes > 0)
{
    Console.Write("Tendrás tres intentos para adivinar un número del 1 al 15, por favor introduzca un número:");
    int respuesta = Convert.ToInt32(Console.ReadLine());

    if (respuesta == numeroCorrecto)
    {
        Console.WriteLine("¡Adivinaste, Enhorabuena!");
        break;
    }
    else if (respuesta < numeroCorrecto)
    {
        Console.WriteLine("El número que buscas es mayor.");
    }
    else
    {
        Console.WriteLine("El número que buscas es menor.");
    }

    intentosRestantes--;
    if (intentosRestantes > 0)
    {
        Console.WriteLine($"Te quedan {intentosRestantes} intentos.");
    }
    else
    {
        Console.WriteLine("¡Has perdido! El número correcto era " + numeroCorrecto);
    }
}