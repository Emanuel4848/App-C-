using System.Runtime.CompilerServices;

partial class Program
{
    static void DataTypes()
    {
        int integer = 42;
        double decimalNumber = 10.2;
        bool isTrue = true;
        char character = 'a';   //solo 1 caracter
        string text = "Hola mundo";

        Console.WriteLine($"Entero: {integer}, decimal: {decimalNumber}, Booleano: {isTrue}, char: {character}, string: {text}");

    }
}