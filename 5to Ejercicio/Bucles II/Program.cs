// IF

Console.WriteLine("Hola, el precio de la mesa es de $20");
Console.WriteLine("Ingrese sus datos por favor");
Console.WriteLine("Nombre:");
string name = Console.ReadLine();

Console.WriteLine("Email:");
string email = Console.ReadLine();

Console.WriteLine("Cupon de descuento:");
string cupon = Console.ReadLine();

const int producto = 20;
int precioFinal = 0;
string cuponPermitido = "HOLAMUNDO";

if (cupon == cuponPermitido)
{
    precioFinal = producto - 5;
    Console.WriteLine($"El precio total de la mesa con el descuento aplicado es de: ${precioFinal}");
}
else if (cupon != cuponPermitido)
{
    Console.WriteLine($"El precio total de la mesa es de: ${producto}");
}

//SWITCH

Console.WriteLine("¿Que lenguajes de programacion es tu favorito?");
Console.WriteLine("1- C#");
Console.WriteLine("2- JAVA");
Console.WriteLine("3- JS");
Console.WriteLine("4- C++");
Console.WriteLine("5- C");
Console.WriteLine("6- KOTLIN");
Console.WriteLine("7- SWIFT");
Console.WriteLine("8- PYTHON");
Console.WriteLine("Ingresa una opcion:");


int lenguaje = Convert.ToInt32(Console.ReadLine());
switch (lenguaje)
{
    case 1:
        Console.WriteLine("Tu lenguaje favorito es C#");
        break;
    case 2:
        Console.WriteLine("Tu lenguaje favorito es JAVA");
        break;
    case 3:
        Console.WriteLine("Tu lenguaje favorito es JS");
        break;
    case 4:
        Console.WriteLine("Tu lenguaje favorito es C++");
        break;
    case 5:
        Console.WriteLine("Tu lenguaje favorito es C");
        break;
    case 6:
        Console.WriteLine("Tu lenguaje favorito es KOTLIN");
        break;
    case 7:
        Console.WriteLine("Tu lenguaje favorito es SWIFT");
        break;
    case 8:
        Console.WriteLine("Tu lenguaje favorito es PYTHON");
        break;
    default:
        Console.WriteLine("Ingresa una opcion correcta");
        break;
}
