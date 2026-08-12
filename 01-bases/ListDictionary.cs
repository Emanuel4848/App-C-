partial class Program
{
    static void ListDictionary()
    {
        //crear e inicializar lista
        List<String> names = new List<string>{"Ana", "Carlos", "Juan"};

        //Agregar elemento a lista existente
        names.Add("Lucia");

        //ver cantidad de nombres
        Console.WriteLine($"Total de nombres: {names.Count}");

        //recorrer una lista
        foreach(var name in names)
        {
            Console.WriteLine(name);
        }

        //remover elemento de una lsita
        names.Remove("Ana");

        //verificar elemento de una lista
        bool existe = names.Contains("Ana");
        Console.WriteLine($"Existe ana?: {existe}"); //imprimio false


        //DICTIONARY

        //crear e inicializar un diccionario
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            {1, "Ana"},
            {2, "Felipe"},
            {3, "Elena"}
        };

        //consultar el "valor" segun su clave
        Console.WriteLine($"El estudiante con ID 1 es: {students[2]}"); //imprimio Felipe



        //recorrer un diccionario
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Nombre: {student.Value}");
        }

    }



}