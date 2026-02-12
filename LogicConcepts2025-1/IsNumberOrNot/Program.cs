using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
//var numberString = string.Empty;
do
{   /*
    Console.Write("Ingrese número entero o la palabra 'Salir' para salir: ");
    numberString = Console.ReadLine(); //Cuando colocamos una var se toma como un string, no como un número. "10"
    //var numberInt = int.Parse(numberString!); //Con la función Parse convertimos el número de String a número. 10
    if(numberString!.ToLower() == "salir")
    {
        continue;
    }*/
    var number = ConsoleExtension.GetInt("Ingrese número entero diferente de cero: ");
    /*
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {*/
    if(number == 0)
    {
        continue;
    }
    if (number % 2 == 0)
    {
        Console.WriteLine($"El número {number}, es par.");
    }
    else
    {
        Console.WriteLine($"El número {number}, es impar.");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
    /*}
    else
    {
        Console.WriteLine($"Lo que ingresaste: {numberString}, no es un número entero.");
    }*/
    
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over");
    