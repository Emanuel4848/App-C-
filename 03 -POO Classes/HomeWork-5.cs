partial class Program
{
    static void ProductSaleDemo()
    {
        //inicializo el inventario;
        Inventory inventary = new Inventory();

        //creo productos
        Product laptop = new Product("Laptop Lenovo", 5000.00, 10 );
        Product mouse = new Product("Mouse Redragon", 300, 5 );

        //agregar al inventario
        inventary.AddProduct(laptop);
        inventary.AddProduct(mouse);

        //ver el inventario
        inventary.showInventory();
        

        //realizar una venta:
        laptop.Venta(3);

        //ver el inventario
        inventary.showInventory();
        

    }
}


class Product
{
    public string? Name {get; set;}
    public double Price {get; set;}
    public int Stock {get; set;}


    public Product(string name, double price, int stock )
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    public void showInfoProduct()
    {
        WriteLine($"Producto: {Name}, Precio: {Price:C}, Stock: {Stock}");
    }

    public bool Venta(int cantidad)
    {
        if (cantidad <= Stock)
        {
            Stock -= cantidad;
            WriteLine($"Venta realizada: {cantidad} de {Name}");
            return true;
        } else
        {
            WriteLine($"Stock insuficiente para {Name}");
            return false;
        }
    }

}

class Inventory
{
    //Creo una lista de tipo Product (es la clase xd)
    private List<Product> products = new List<Product>();

    //Metodo para agrega productos a la lista
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    //metodo para mostrar el inventario.
    public void showInventory()
    {
        WriteLine("--Inventario de productos--");
        foreach (var product in products)
        {
            product.showInfoProduct();
        }
    }

}