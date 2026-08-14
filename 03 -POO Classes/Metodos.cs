partial class Program

{
    static void Metodos()
    {
        //Consturctor por defecto
        Carro myCar = new Carro ();
        myCar.Modelo = "Yaris";
        myCar.Anio = 2026;
        WriteLine(myCar.verInfo()); //Automóvil: Yaris, del Año: 2026

        //cambiar modelo
        myCar.verMensaje("Cambiando modelo");
        myCar.cambiarModelo("Yaris 2.0");
        WriteLine(myCar.verInfo()); //Automóvil: Yaris 2.0, del Año: 2026
        Carro.InfoGeneral();       //El automovil es uno de los transportes mas usados
        
        //Consturctor de la clase
        Carro myDeportivo = new Carro("Bugati", 2016);
        WriteLine(myDeportivo.verInfo());


        Carro myCollection = new Carro { Modelo = "Cadillac", Anio = 1990};
        WriteLine(myDeportivo.verInfo());


        //Colecciones o Listas de objetos
        List<Carro> cars = new()
        {
            new Carro() {Modelo= "Duster", Anio= 2021},
            new Carro() {Modelo= "DStepWay", Anio= 2019},
            new Carro() {Modelo= "Captur", Anio= 2001}
        };

        foreach (var item in cars)
        {
            WriteLine(item.verInfo());
        }



    }


}

class Carro
{
    public string? Modelo {get; set;}
    public int Anio {get; set;}

    //consturctor por parametros
    public Carro(string modeloC, int anioC)
    {
        Modelo = modeloC;
        Anio = anioC;
    }
    //constructor por defecto
    public Carro () {}


    //destructor (~)
    ~Carro()
    {
        WriteLine("Destructor llamado. Recurso Liberado");
    }



    //Metodo para cambiar una propiedad
    public void cambiarModelo(string nuevoModelo)
    {
        Modelo = nuevoModelo;
    }

    //Metodo para retornar un valor
    public string verInfo()
    {
        return $"Automóvil: {Modelo}, del Año: {Anio}";
    }

    //sobreCarga de metodos: Metodos mismo name, difententes funcionalidades
    public void verMensaje() => WriteLine("Este es un Automovil");
    public void verMensaje(string mensaje) => WriteLine(mensaje);

    //metodo estatico
    public static void InfoGeneral()
    {
        WriteLine("El automovil es uno de los transportes mas usados");
    }

}