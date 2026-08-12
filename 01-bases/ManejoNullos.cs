partial class Program
{
    static void ManejoDeNullos()
    {
        //no Nullo
        string firstName = "Carlos";

        //Nullo
        string? lastName = null;


        Console.WriteLine($"Nombre: {firstName}");

        //Operador de coalescencia nula ??
        Console.WriteLine($"Apellido: {lastName ?? "Apellido no especificado"}");

        //Operador de acceso Nulo seguro ?.
        string? text = null;
        Console.WriteLine(text?.Length);

    }
}