partial class Program
{
    static void InventoryManager2()
    {
        string[] Productos = ["Monitor", "Mouse", "Teclado"];
        int[] stock = [10, 25, 30];
        double[] prices = [250.50, 20.50, 45.00];

        Console.WriteLine("1. Comprar producto");
        Console.WriteLine("2. Salir");
        Console.WriteLine("");
        Console.WriteLine("Ingrese una opción: ");
        int option = int.Parse(Console.ReadLine()!);

        if (option == 1)
        {

            Console.WriteLine("Inventario de productos");
            Console.WriteLine("-----------------------");
            for (int i = 0; i < Productos.Length; i++)
            {
                Console.WriteLine($"Producto: {Productos[i]}, Precio: {prices[i]:C}, Cantidad disponible: {stock[i]}");
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
                        stock[i] -= cantidad;
                        Console.WriteLine($"El total es de {resultado:C} ");
                        Console.WriteLine($"El stock para el producto {Productos[i]} es {stock[i]}");
                    
                    }
                    else
                    {
                        Console.WriteLine("No hay suficiente stock");
                    }
                }

            }

        } else if (option == 2)
        {
            Console.WriteLine("Gracias por su visita");
        } else
        {
            Console.WriteLine("Opcion invalida");
        }
    }
}