//Partial: Une todos los partial y crea una sola clase Program.
partial class Program
{
    static void Classes()
    {
        //INSTANCIA DE MI CLASE
        Vehiculo toyota = new Vehiculo();
        toyota.Marca = "Toyota";
        toyota.Model = "Grande";
        toyota.Year = 2020;
        toyota.ShowInfo();

        //INSTANCIA DE MI CLASE: Inicialización directa
        Vehiculo honda = new Vehiculo{Marca = "Honda", Model = "Civic",  Year = 2019};
        honda.ShowInfo();

        //INSTANCIA SOBRE MI CONTRUCTOR DE LA CLASE
        Vehiculo renault = new Vehiculo("Renault", "Monster", 2024);
        renault.ShowInfo();

    }
}


//Crear clase
class Vehiculo
{
    //Propiedades
    public string? Marca {get; set;}
    public string? Model {get; set;}
    public int Year {get; set;}

    //Metodos

    //Metodos contructor dentro de la clase
    public Vehiculo(string marca, string model, int year)
    {
        Marca = marca;
        Model = model;
        Year = year;
    }
    public Vehiculo() {}

    public void ShowInfo()
    {
        WriteLine($"El vehiculo es Marca: {Marca}, Modelo: {Model}, del año {Year}");
    }
}