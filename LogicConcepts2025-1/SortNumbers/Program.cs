do
{
    Console.WriteLine("Ingrese 3 números diferentes");

    Console.Write("Ingres primer número: ");
    var number1String = Console.ReadLine();
    var number1Int = int.Parse(number1String!);
    Console.Write("Ingrese segundo número: ");
    var number2String = Console.ReadLine();
    var number2Int = int.Parse(number2String!);
    if(number1Int == number2Int)
    {
        Console.WriteLine("Deben ser diferentes, vuelva a empezar");
        continue;
    }
    Console.Write("Ingrese tercer número: ");
    var number3String = Console.ReadLine();
    var number3Int = int.Parse(number3String!);
    if(number2Int == number3Int || number3Int == number1Int)
    {
        Console.WriteLine("Deben ser diferentes, vuelva a empezar");
        continue;
    }


    if(number1Int > number2Int && number1Int > number3Int)
    {
        if(number2Int > number3Int)
        {
            Console.WriteLine($"El mayor es {number1Int}, el medio es {number2Int}, el menor es {number3Int}");
        }
        else
        {
            Console.WriteLine($"El mayor es {number1Int}, el medio es {number3Int}, el menor es {number2Int}");
        }
    }
    else if (number2Int > number1Int && number2Int > number3Int)
    {
        if (number2Int > number3Int)
        {
            Console.WriteLine($"El mayor es {number2Int}, el medio es {number1Int}, el menor es {number3Int}");
        }
        else
        {
            Console.WriteLine($"El mayor es {number2Int}, el medio es {number3Int}, el menor es {number1Int}");
        }
    }
    else
    {
        if (number2Int > number3Int)
        {
            Console.WriteLine($"El mayor es {number3Int}, el medio es {number1Int}, el menor es {number2Int}");
        }
        else
        {
            Console.WriteLine($"El mayor es {number3Int}, el medio es {number2Int}, el menor es {number1Int}");
        }
    }

} while(true);