
Data client = new Data("Gonzalo Giuliani", 222222222, "Mendoza,Argentina", "holamundo@open.com", "Nuevo Cliente");

Console.WriteLine("Datos del cliente:");
Console.WriteLine("Nombre: " + client.Nombre);
Console.WriteLine("Telefono: " + client.Telefono);
Console.WriteLine("Direccion: " + client.Direccion);
Console.WriteLine("Email: " + client.Email);
Console.WriteLine("Tipo de cliente: " + client.TipoDeCliente);

public struct Data
{
    public string Nombre;
    public int Telefono;
    public string Direccion;
    public string Email;
    public string TipoDeCliente;
    public Data(string name, int phone, string address, string email, string newClient)
    {
        Nombre = name;
        Telefono = phone;
        Direccion = address;
        Email = email;
        TipoDeCliente = newClient;
    }

}