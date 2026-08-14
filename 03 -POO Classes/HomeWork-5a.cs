using System.Runtime.CompilerServices;

partial class Program
{
    static void ProductSalesDemo2()
    {
        Fleet fleet = new Fleet();

        Bus toyota = new Bus("Toyota", "Corolla", 2022, 20000, 35000);
        Bus honda = new Bus("Honda", "Civic", 2021, 25000, 40000);
        Bus nissan = new Bus("Nissan", "Sentra", 2023, 21500, 30000);

        fleet.AddBus(toyota);
        fleet.AddBus(honda);
        fleet.AddBus(nissan);

        fleet.showFleet();

        toyota.Drive(5000);
        honda.Drive(5000);
        nissan.Drive(5000);

        WriteLine("--Despus de manejar 5000 km--");

        fleet.showFleet();

        
    }
}


class Bus
{
    public string? Brand {get; set;}
    public string? Model {get; set;}
    public int Year {get; set;}
    public double Price {get; set;}
    public double TotalKilometers {get; set;}

    public Bus(string brand, string model, int year, double price, double totalKilometers)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Price = price;
        TotalKilometers = totalKilometers;
    }

    public void Drive(double kilometers)
    {
        TotalKilometers = TotalKilometers + kilometers;
    }

    public void showPrice()
    {   
        WriteLine($"El precio es de {Price:C}");
    }
}


class Fleet
{
    private List<Bus> buses = new List<Bus>();

    public void AddBus(Bus bus)
    {
        buses.Add(bus);
    }

    public void showFleet()
    {
        foreach(var bus in buses)
        {
            WriteLine($"Marca: {bus.Brand}, Modelo: {bus.Model}, Año: {bus.Year}, Kilometraje: {bus.TotalKilometers}, Precio: {bus.Price:C}");
        }
    }
}
