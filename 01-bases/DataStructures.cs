partial class Program
{
    static void DataStructures()
    {
        //instancia1 de mi clase user
        User pedro = new User {Name= "Ema", Age = 33};
        pedro.Gree();

        //instancia de mi struct Punto
        Punto puntoMap = new Punto{x= 30, y = 20};
        Console.WriteLine($"Punto({puntoMap.x}, {puntoMap.y})");

        //instancia de mi record
        Telefono newIphone = new Telefono("AppleTouch", 2026);
        Console.WriteLine(newIphone);


    }
}


//CLASE/contruct user
class User
{
    //Propiedades
    public string? Name {get; set;}
    public int Age {get; set;}

    //Metodo
    public void Gree()
    {
        Console.WriteLine($"Hola soy {Name}, y tengo {Age} años");
    }

}


//crear STRUCT/contructor
struct Punto
{
    //Propiedades
    public int x {get; set;}
    public int y {get; set;}

}

//Crear RECOTRD/contructor
record Telefono(string Model, int Year);