partial class Program
{
    static void Generics()
    {
        string[] names = ["Juan", "Luis", "Diana"];
        int[] numbers = [1,2,3, 6];

        Console.WriteLine($"El tamaño del arreglo numerico: {GetTamañoArray(numbers)}");

        Console.WriteLine($"El tamaño del arreglo nombes: {GetTamañoArray(names)}");

        
    }


    //metodos sin el uso de genericos

    //Funcion/Metodo para int
    static int GetTamañosArreglosInt(int[] array) //recibe array de enteros
    {
        return array.Length;
    }

    //Funcion/Metodo para strings
    static int GetTamañosArreglosString(string[] array) //recibe array de strings
    {
        return array.Length;
    }


    //Metodo generico

    static int GetTamañoArray<T>(T[] array) //recibe array de cualquier tipo
    {
        return array.Length;
    }
}