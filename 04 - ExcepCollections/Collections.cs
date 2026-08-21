using Microsoft.VisualBasic;

partial class Program
{
    static void Collections()
    {
        //Crear coleccion y de paso datos
        List<string> names = ["Luis", "Pedro", "Pablo"];
        //agregar algo a la coleccion:
        names.Add("Ema");
        //showNames(names);

        //remover algo de la lista
        names.Remove("Luis");


        //inicializo y agrego
        Dictionary<int, string> students = new()
        {
            {1, "Ana"},
            {2, "Carlos"},
            {3, "Pablo"}
        };

        //agregar uno
        students.Add(4, "Ema");

        //imprimir: ojo, calve - valor
        showStudents(students);

        //remover: (key)
        students.Remove(1);


        //Inicializar y con datos
        HashSet<string> users = ["Luis", "Pedro", "Pablo"];

        //agregar
        users.Add("Ema");
        users.Add("Luis");     //  <--- Ojo ese no lo agrega pq ya existe




    }

    private static void showStudents(Dictionary<int, string> students)
    {
        foreach (var student in students)
        {
            WriteLine($"Llave: {student.Key}, Valor: {student.Value}");
        }
    }

    private static void showNames(List<string> names)
    {
        foreach (var name in names)
        {
            WriteLine(name);
        }
    }
}


