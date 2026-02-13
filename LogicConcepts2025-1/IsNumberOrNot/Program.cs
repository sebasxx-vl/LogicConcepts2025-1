using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
//var numberString = string.Empty;
do
{   /*
    Console.Write("Ingrese número entero o la palabra 'Salir' para salir: ");
    numberString = Console.ReadLine(); //When we place a variable, it is treated as a string, not as a number. "10"
    //var numberInt = int.Parse(numberString!); //Using the Parse function, we convert the String number to a number. 10
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

//The dollar sign is interpolation
