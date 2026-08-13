partial class Program
{

    //funcion creada
    static double CalculateArea(double width, double height) 
    {
        return width * height;
    }


    //funcion para saber si un numero es negativo, postivo o cero
    static string evaluationNumber(int number)
    {
        if (number > 0)
        {
            return "Positivo";
        } else if (number < 0 ) 
        {
            return "Negativo";
        } else
        {
            return "Cero";
        }
    }

    static void Functions()
    {
        
        //consumir o llamar Funcion
        var area = CalculateArea(4.5, 2.23);
        WriteLine($"El area es {area}");


        //llamda xd
        var evaluacion = evaluationNumber(5);
        WriteLine($"El numero es {evaluacion}");
    }
}