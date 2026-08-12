partial class Program
{
    static void SalesReport()
    {


        //Crear reporte de ventas
        string product = "Laptop";
        int quantitySold = 3;
        double unitPrice = 750.99;
        double totalAmount = quantitySold * unitPrice;

        Console.WriteLine($"Producto: {product}");
        Console.WriteLine($"Cantidad Vendida: {quantitySold}");
        Console.WriteLine($"Precio Unitario: {unitPrice}");
        Console.WriteLine($"Total generado: {totalAmount:C}");   //convierte a moneda nacional xd
    }


    static void SalaryCalculator()
    {


        //Calculadora de salario

        Console.WriteLine("Calculadora de salario" + "\n");
        Console.Write("Ingrese su nombre: ");
        string? name = Console.ReadLine();        //permite nulls

        Console.Write("Ingrese el número de horas trabajadas: ");
        double hoursWorked = double.Parse(Console.ReadLine()!);  //parsea string a dobul y !: No permite nullos

        Console.Write("Ingrese el salario por hora: ");
        double hourlyRate = double.Parse(Console.ReadLine()!);

        double salary = hourlyRate * hoursWorked;
        Console.WriteLine($"El salario para {name} es de: {salary}");


    }
}