// >=
Console.WriteLine("Escriba un número mayor o igual a 18");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("el número ingresado es mayor o igual a 18: " + (number>=18));
// CHAR
Console.WriteLine("Escriba la letra a");
char letter = Convert.ToChar(Console.ReadLine());   
Console.WriteLine("la letra ingresada es a: " + (letter=='a'));
//TWO TRUE
Console.WriteLine("¿Usted que edad tiene?");
int yearOld = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("¿Cuantas maletas tiene?");
int baggage = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Usted tiene 18 años y 2 maletas: "+(yearOld==18 &baggage==2));
// TRUE FALSE
Console.WriteLine("¿Usted que edad tiene?");
int myYears = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿Y su hermano?");
int brotherYears = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Solo pueden ingresar si alguno de los dos es mayor de 18 años: "+(myYears>=18 || brotherYears>=18));

