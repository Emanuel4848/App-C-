partial class Program
{
    static void arrays()
    {
        //con constructor e inicialización:
        int[] numbers = new int[5];   //tendra 5 elementos.
        numbers[0] = 1;              //indice 0 con valor 1.


        //Directa
        int[] numbers2 = [5,10,15,25];

        //rangos para sub arreglos: ..
        int[] numeros3 = numbers2[..3];  //los primero 3 indices del arreglo "numbers". (6,10,15)
        foreach(var i in numeros3)
        {
           Console.WriteLine(i); 
        }


        int[] numero4 = numbers2[2..];   //desde el indice 2 en adelante (15,25)
        foreach(var i in numero4)
        {
           Console.WriteLine(i); 
        }

    }
}