using System.Globalization;

partial class Program
{
    static void ConvertionToDateTime()
    {
        //Definir la cultura dle sistema (español españa)(DD/MM/YYYY)
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-ES");


        int friends = int.Parse("101");

        double costoEntrada = 25.50;

        DateTime cumpleaños = DateTime.Parse("12 Agosto 2026");

        WriteLine($"Tengo {friends} amigos para invitar a mi fiesta");
        WriteLine($"La fiesta es {cumpleaños}"); //es "12/08/2026 00:00:00"
        WriteLine($"La fiesta es {cumpleaños:D}"); //es "Miercoles, 12 de agosto"
        WriteLine($"La fiesta es {cumpleaños:d}"); //es "12/08/2026"

        WriteLine($"El costo de la entrada sera: {costoEntrada}");   //sera: "25,5"
        WriteLine($"El costo de la entrada sera: {costoEntrada:C}"); //sera: "25,20 €


    }
}