using System.Data;

partial class Program
{
    static void ShowTime()
    {
        

        DateTime actualidad = DateTime.Now;                  //Hora y fecha actual.
        DateTime hoy = DateTime.Today;                      //fecha actual
        DateTime semanAnterior = hoy.AddDays(-7);          //Fecha semana anterior
        DateTime customDate = new DateTime(2005, 09, 24);  //crear fecha personalziada

        DayOfWeek diaDeLaSemana = actualidad.DayOfWeek;    //Dia de la semana

        Console.WriteLine($"Fecha y hora actual: {actualidad}");
        Console.WriteLine($"Fecha actual: {hoy}");
        Console.WriteLine($"Hace una seman la fecha {actualidad.ToString("dd/MM/yyyy")} era {semanAnterior.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Fecha personalziada: {customDate}");
        Console.WriteLine($"Estamos en el dia de la semana: {diaDeLaSemana}");




    }
}