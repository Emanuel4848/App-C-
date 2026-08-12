partial class Program
{
    static void ShowNumericTypes()
    {
        //enteros
        int integerNumber = 48;
        long  LongNumber = 121_231_23L;       //numero grandes > int


        //decimales de comun a menosComun
        decimal monetaryNumber = 99.99m;     //mucha precision
        double decimalNumber = 3.1416;        //precision normal
        float floatingNumber = 274f;         //menos preciso pero menos memoria uso


        //extra: el compilador le asigna el tipo
        //cre que es aginar el typo en el dato:
        var numero1  = 42f;   

        
        Console.WriteLine($"Entero: {integerNumber}");
        Console.WriteLine($"Long: {LongNumber}");
        Console.WriteLine($"Decimal: {monetaryNumber}");
        Console.WriteLine($"Double: {decimalNumber}");
        Console.WriteLine($"float: {floatingNumber}");
        Console.WriteLine($"extra: {numero1}");
    
    }

}