partial class Program
{
    static void DirectoryExample()
    {
        //ruta donde se ejecturá (osea done se creara la carpeta o eliminara)
        var directoryPath = "./05 - files";

                                    //ruta donde, nombreDirectorioNew
        Directory.CreateDirectory($"{directoryPath}/DirEjemplo/OtherDir");

                            //ruta
        if(Directory.Exists($"{directoryPath}/DirEjemplo/OtherDir"))
        {
            WriteLine("El directorio ya existe");
        }
                            //solo se borra la ultima carpeta
        Directory.Delete($"{directoryPath}/DirEjemplo/OtherDir", recursive: true);
    }
}