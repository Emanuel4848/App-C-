partial class Program
{
    static void FuncionesAnonimas()
    {
        //invocación
        WriteLine(cuadrado(5));

        //invocación con lambda
        WriteLine(lambdaCuadrado(4));

        //Creo lsitas de numeros enteros
        List<int> numbers = [1,2,3,4,5];

        //con lamba devuelvo solo los numeros pares. (n es iterando), (lambda es =>)
        var evenNumbers = numbers.Where(n => n % 2 == 0);


        //inicio la iteracion ya preparada arriba
        foreach (var even in evenNumbers)
        {
            WriteLine(even);
        }

        
    }

    //funcion anonima
            //<lo que ingresa, lo que devuelve>
            //cuadrado es el nombre de la funcion xd 
            //delegate es clave
    static Func<int, int> cuadrado = delegate (int number)
    {
        return number * number;
    };


    //funcion anonima con lambda
        //ojo aqui x es el parametro que recibe
    static Func<int, int> lambdaCuadrado = s => s * s; 
}