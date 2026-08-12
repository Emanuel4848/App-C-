partial class Program
{
    static void operators()
    {
        int number = 15;
        bool esPar = number % 2 == 0;
        bool mayor10 = number > 10;

        if (esPar && mayor10)
        {
            Console.WriteLine($"El numero {number} es Par y mayor a 10");
        }
        else if (!esPar && mayor10)
        {
            Console.WriteLine($"El numero {number} es Impar y mayor a 10");
        }
        else if (esPar && !mayor10)
        {
            Console.Write($"El numero {number} es par y menor a 10");
        }
        else
        {
            Console.WriteLine($"El numero {number} no cumple con las condiciones");
        }

        //Operador ternario  ? true:false

        int age = 21;
        string esAdulto = age >= 18 ? "Adulto": "Menor de edad";
        Console.WriteLine(esAdulto);


    }
}