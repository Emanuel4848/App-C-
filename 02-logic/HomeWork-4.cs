partial class Program
{
    static void printTablaMultiplicar(int multiplciador, int limite = 10) //por si no mandan limite xd = 10
    {   

        WriteLine($"La tabla de multiplicar del numero {multiplciador} es del 1 hasta el {limite}");
        WriteLine();
        for (int i = 1; i<= limite; i++)
        {
            WriteLine($"{i} * {multiplciador} = { i * multiplciador}");
        }
        WriteLine();


    }

}