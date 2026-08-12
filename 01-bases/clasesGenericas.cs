partial class Program
{
    static void claseGenerica()
    {
        
        //intancias de clase Generica
        Box<int> numeroBoxd = new Box<int> {Contenidoxd = 50};
        Box<string> numeroBoxd2 = new Box<string> {Contenidoxd = "Buenas"};

        numeroBoxd.verxd();
        numeroBoxd2.verxd();
    }
}

//crear Clase generica
class Box<T>
{
    //propiedades
    public T? Contenidoxd {get; set;}

    //metodos
    public void verxd()
    {
        Console.WriteLine($"Contenido: {Contenidoxd}");
    }
}