partial class Program
{
    static void PathExample()
    {
        var rutaArchivo = "./05 - files/Ejemplo.txt";

        //Extrar nombre de un archivo
        var NombreArchivo = Path.GetFileName(rutaArchivo);
        WriteLine($"Nombre del archivo: {NombreArchivo}");

        //Extrar la extension de un archivo
        var extensionArchivo = Path.GetExtension(rutaArchivo);
        WriteLine($"Extension del archivo: {extensionArchivo}");

        //Extrar el name de la carpeta de un archivo
        var NombreDirectory = Path.GetDirectoryName(rutaArchivo);
        WriteLine($"Carpeta del archivo: {NombreDirectory}");

        //combinar o construir rutas
        var CombinarRutas = Path.Combine("C:", "User", "Documents", "Ejemplo.txt");
        WriteLine($"Ruta Combinada: {CombinarRutas}");

        //ruta completa de un archivo:
        var rutaCompelta = Path.GetFullPath(rutaArchivo);
        WriteLine($"Ruta completa: {rutaCompelta}");


        
    }
}