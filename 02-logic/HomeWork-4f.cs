partial class Program
{
    
    static void PrintFactorialTable(int number)
    {
        WriteLine($"Factorial del número {number}, desde el 1 hasta el {number}");
        for (int i = 1; i<=number; i++)
        {
            int r1 = 1;
            // i = 1 y number = 5

            for (int x = i; x>1; x-- ) //x 5
            {
                r1 = r1 * x;   //1(5).   1 * 5 = 5
                               //2(4).   5 * 4 = 20
                               //3(3).   20 * 3 = 60
                               //3(2).   60 * 2 = 120
                               //3(1).   no entra, r1 es 120 xd
            }
            WriteLine($"{i}! = {r1}");
           

            
        }
    }


    //fucnion encargada de mostrar la tala
    static void PrintFactorialTableClase(int number)
    {
        WriteLine($"Factorial del número {number}, desde el 1 hasta el {number}");
        WriteLine();

        for (int i = 1; i<=number; i++)
        {
            WriteLine($"{i}! = {factorial(i)}");
        }
        WriteLine("");


    }
    //funcion encargada de calcular el factorial
    static int factorial(int number)
    {
        int r1 = 1;
        for (int i = 1; i<=number; i++)
        {
            r1 = r1 * i;
        }
        return r1;
    }

}