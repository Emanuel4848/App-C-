partial class Program
{
    
    static void Tuples()
    {
        
        //tupla definiendo los tipos de datos
        (int, string) myTuple = (42, "Hola");

        //FORMA 1: leer tupla o recuperar datos de una tupla
        WriteLine($"Número: {myTuple.Item1}, stirng: {myTuple.Item2}");



        //tupla Definiendo tipos de datos y un nombre o variable
        (int myNumero, string myTexto) myTuple2 = (42, "Hola");
    
        //leer tupla o recuperar datos de una tupla
        WriteLine($"Número: {myTuple2.myNumero}, stirng: {myTuple2.myTexto}");


        var llamarFun = operaciones(20, 10);

        WriteLine($"Suma: {llamarFun.suma}, Resta: {llamarFun.resta}");

        // invoco a la funcion de forma desestucturación
        (int SUMA, int RESTA) = operaciones(25, 10);
        WriteLine($"Suma: {SUMA}, Resta: {RESTA}");

    }


            //aqui defino lo k devuelve
    static (int suma, int resta) operaciones(int a, int b)
    {
        return (a+b, a-b);     //revueldo tupla
    }
}