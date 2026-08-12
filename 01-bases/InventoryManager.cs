partial class Program
{
    static void InventoryManager()
    {
        string[] Productos = ["Monitor", "Mouse", "Teclado"];
        int[] stock = [10, 25, 30];
        double[] prices = [250.50, 20.50, 45.00];

        
        Console.WriteLine("Inventario de productos");
        Console.WriteLine("-----------------------");
        for (int i = 0; i < Productos.Length; i++)
        {
            Console.WriteLine($"Producto: {Productos[i]}, Precio: {prices[i]}, Cantidad disponible: {stock[i]}");
        }

        Console.Write("Que Producto desea comprar: ");
        string? producto = Console.ReadLine();
        
        Console.Write("Cantidad de producto: ");
        int cantidad = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < Productos.Length; i++)
        {
            if (Productos[i].Equals(producto, StringComparison.OrdinalIgnoreCase))
            {
                if (cantidad <= stock[i])
                {
                    double resultado = cantidad * prices[i];
                    Console.WriteLine($"El total es de {resultado:C} ");
                } else
                {
                    Console.WriteLine("No hay suficiente stock");
                }
            }

        }



    }
}