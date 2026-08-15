partial class Program
{
    static void ClasesAbstractas()
    {
        Lavadora myLavadora = new Lavadora {Marca = "Samsung"};
        Microondas myMicroondas= new Microondas {Marca = "Samsung"};


        myLavadora.VerMarca();

        //Polimorfismo:
        myLavadora.Encender();
        myMicroondas.Encender();
    }
}

abstract class Electodomesticos
{
    public string? Marca {get; set;}

    //No se desarrollo, solo se creo.
    public abstract void Encender();

    public void VerMarca()
    {
        WriteLine($"La marca del electrodomestico es {Marca}");
    }

}

class Lavadora : Electodomesticos
{
    public override void Encender()
    {
        WriteLine("Lavadora a inicializado el ciclo de lavado");
    }
}

class Microondas: Electodomesticos
{
    public override void Encender()
    {
        WriteLine("Microondas está calentando la comida");
    }
}