partial class Program
{
    static void WriteFileExample()
    {
        //rta del archivo donde voy a escribir (no existe):
        var rutaArchivo = "./05 - files/EjemploEscritura.txt";

        //El contenido k voy a escribr
        var contenido = "Hola estoy escribiendo xd";


        //aqui preapror y mandar xd
        var PrepararEscritura = new StreamWriter(rutaArchivo, append: true);
        PrepararEscritura.WriteLine(contenido);      // <-- aqui mando la primera line(contenido)
        PrepararEscritura.WriteLine("HOOLAA LA HORA ESS: " + DateTime.Now.ToString("HH:mm:ss")); // Otra linea

        //ciero el archivo
        PrepararEscritura.Dispose();

        WriteLine("Archivo creado existosamente");
        
    }
}