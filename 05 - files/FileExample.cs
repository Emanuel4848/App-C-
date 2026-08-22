partial class Program
{
    static void FileExample()
    {
        var ruta = "./05 - files/Ejemplo.txt";
        //Ler un archivo
        var contenido = File.ReadAllText(ruta);
        //WriteLine(contenido);

        var LeerLineas = File.ReadAllLines(ruta);
        //WriteLine(LeerLineas[1]);
        
        foreach (var line in LeerLineas)
        {
           // WriteLine(line);
        }


                  //ruta origen, ruta pegar destino,soobrescribir?
        File.Copy(ruta,"./05 - files/EjemploCopia.txt", overwrite: true);


        File.Delete("./05 - files/EjemploCopia.txt");
    }


}