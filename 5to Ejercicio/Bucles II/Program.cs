// IF

Console.WriteLine("Hola, el precio de la mesa es de $20");
Console.WriteLine("Ingrese sus datos por favor");
Console.WriteLine("Nombre:");
string name= Console.ReadLine();

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
