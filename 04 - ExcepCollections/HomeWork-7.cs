partial class Program
{
    static void SalesAnalysis()
    {
        try
        {
            List<Sale> sales = new List<Sale> {
            new Sale("Laptop", "Electrónica", 1500),
            new Sale("Teléfono", "Electrónica", 900),
            new Sale("Silla", "Muebles", 1200),
            new Sale("Escritorio", "Muebles", 800),
            new Sale("Tablet", "Electrónica", 1300),
            new Sale("Lámpara", "Iluminación", 400)
        };

       // 1. Filtrar y mostrar las ventas con monto superior a 1000.

        var ventasMayor1000 = from s in sales
                              where s.Amount > 1000
                              select s;

        WriteLine("Ventas mayor a 1000");
        foreach (var venta in ventasMayor1000)
        {
            WriteLine($"Producto: {venta.Product}, Categoría: {venta.Category}, Monto: {venta.Amount:C}");
        }

        //2. Agrupar las ventas por categoría y calcular el total de ventas por categoría.

        
        var ventasPorCategoria = from s in sales
                                 group s by s.Category into ventasAgrupadas
                                 select new {venta = ventasAgrupadas.Key, Suma = ventasAgrupadas.Sum(x => x.Amount)};
        WriteLine("\nTotal de ventas por categoria");
        foreach (var venta2 in ventasPorCategoria)
        {
            WriteLine($"Categoria:{venta2.venta}, Total ventas: {venta2.Suma:C}");
        }

        }catch (Exception ex)
        {
            WriteLine($"Error al procesar las ventas {ex.Message}");
        }
        

    }
}

class Sale
{
    public string? Product { get; set; }
    public string? Category { get; set; }
    public double Amount { get; set; }

    public Sale(string product, string category, double amount)
    {
        Product = product;
        Category = category;
        Amount = amount;
    }
}