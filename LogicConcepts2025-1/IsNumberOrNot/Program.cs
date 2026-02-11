var numberString = string.Empty;
do
{
    Console.Write("Ingrese número entero o la palabra 'Salir' para salir: ");
    numberString = Console.ReadLine(); //Cuando colocamos una var se toma como un string, no como un número. "10"
    //var numberInt = int.Parse(numberString!); //Con la función Parse convertimos el número de String a número. 10
    if(numberString!.ToLower() == "salir")
    {
        continue;
    }
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número {numberInt}, es par.");
        }
        else
        {
            Console.WriteLine($"El número {numberInt}, es impar.");
        }
    }
    else
    {
        Console.WriteLine($"Lo que ingresaste: {numberString}, no es un número entero.");
    }
} while (numberString.  ToLower() != "salir");
Console.WriteLine("Game Over");
    