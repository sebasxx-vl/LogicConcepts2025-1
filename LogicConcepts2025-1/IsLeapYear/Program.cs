using Shared;

do
{
    //Como capturar un año
    var currentYear = DateTime.Now.Year;
    var message = string.Empty;
    var year = ConsoleExtension.GetInt("Ingrese año: ");

    if(year == currentYear)
    {
        message = "es";
    }
    else if (year > currentYear)
    {
        message = "va a ser";
    }
    else
    {
        message = "fue";
    }

    if (year % 4 == 0 )
    {
        //Puede que sea biciesto si es modulo de 4
        if(year % 100 == 0)
        {
            //Puede que sea biciesto si es modulo de 4 y de 100, falta verificar el 400
            if(year % 400 == 0)
            {
                Console.WriteLine($"El año: {year}, Si {message} biciesto");
            }
            else
            {
                Console.WriteLine($"El año: {year}, No {message} biciesto");
            }
        }
        else
        {
            Console.WriteLine($"El año: {year}, Si {message} biciesto");
        }
    }
    else
    {
        Console.WriteLine($"El año: {year}, No {message} biciesto");
    }
} while (true);