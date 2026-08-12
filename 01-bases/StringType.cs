partial class Program
{
    static void ShowStringType()
    {
        
        //crear strings
        string name = "Juan";
        string message = "Hola " + name;  //concatenar
        string interpolatedMessage = $"Hola {name}";    //interpolar:


        //manipular cadenas
        Console.WriteLine(name.Length);          //salida = 4
        Console.WriteLine(name.ToUpper());      //convertir string en mayusculas
        Console.WriteLine(name.ToLower());      //convertir string en minusculas
 
        //convertir datos a string
        int number = 13;
        Console.WriteLine(number.ToString());
        bool isTrue = true;
        Console.WriteLine(isTrue.ToString());



    }
}