using System.Globalization;
partial class Program
{
    static void diasVividos()
    {
        
        DateTime nacimiento = new DateTime(2005,9,24);       //customizo mi fecha de nacimiento
        TimeSpan restaDeFechas = DateTime.Now - nacimiento;  // resta de Fecha Actual - nacimiento

        Console.WriteLine($"Has vivido {restaDeFechas.Days} dias");

    }








    static  void calcularDiasProximoCumple()
    {

        


        Console.Write("Ingrese la fecha cumpleaños (dd/mm/yyyy): ");  
        string nacimientoString = Console.ReadLine()!;  //leo Fecha como string     (24/09/2026)
        DateTime nacimientoParseado = DateTime.ParseExact(nacimientoString, "dd/MM/yyyy", CultureInfo.InvariantCulture); //(24/09/2026)

        DateTime actual = DateTime.Now.Date;    //le digo que solo fecha, sin hora. (08/08/2026)
        DateTime sigCumple = new DateTime(actual.Year, nacimientoParseado.Month, nacimientoParseado.Day); //custom: (2026, 09, 24)

        //ahora vienen validaciones

        if(sigCumple < actual)  //si la fecha cumpl es menor que la actual (osea ya paso)
        {
            sigCumple = sigCumple.AddYears(1);  //a la fecha sigCumple le sumo un año, esto cuenta mas dias y pues da.
        }

        int diasRestantes = (sigCumple - actual).Days;   

        Console.WriteLine($"Quenda {diasRestantes} para tu proximo cumpleaños");

    



    }
}