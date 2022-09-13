// WHILE
Console.WriteLine("Ingrese un numero para multiplicar por 10:");
int num = Convert.ToInt32(Console.ReadLine());
int res = 0;
int cont = 1;
while (cont <= 10)
{
    res = cont * num;
    Console.WriteLine($"{num} x {cont} = {res}");
    cont++;
}

// DO WHILE
Console.WriteLine("INGRESE 4 NUMEROS");
int contador = 0;
int contPositivo = 0;
int contNegativo = 0;
do
{
    Console.WriteLine("Ingrese un numero:");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
    {
        Console.WriteLine("El numero ingresado es POSITIVO");
        contPositivo += 1;
    }
    if (number < 0)
    {
        Console.WriteLine("El numero ingresado es NEGATIVO");
        contNegativo += 1;
    }
    contador++;
} while (contador < 4);

Console.WriteLine($"Ingreso {contPositivo} numeros POSITIVOS, y {contNegativo} numeros NEGATIVOS");

// FOR

Console.WriteLine("Ingrese las medidas de la figura a dibujar en cm");
Console.WriteLine("Alto:");
int height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ancho:");
int width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿Con relleno?");
string filling = Console.ReadLine();

for (int i = 0; i < width; i++)
{
    Console.Write(" * ");
}
Console.WriteLine();

for (int j = 0; j < height - 2; j++)
{
    Console.Write(" * ");
    if (filling == "si")
    {
        for (int k = 0; k < width - 2; k++)
        {
            Console.Write(" * ");
        }
        Console.Write(" * \n");

    }
    else
    {
        for (int k = 0; k < width - 2; k++)
        {
            Console.Write("   ");
        }
        Console.Write(" * \n");
    }
}

for (int i = 0; i < width; i++)
{
    Console.Write(" * ");
}

