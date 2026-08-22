using System.Text.Json;

namespace ManageJsonFile
{
    class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public string? Team { get; set; }
    }
    partial class Program
    {
        public static void ManageJsonFile()
        {
            List<Character> characters =
            [
              new Character { Id = 1, Name = "Peter Parker", Alias = "Spider", Team = "Avengers" },
        new Character { Id = 2, Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
        new Character { Id = 3, Name = "Steve Rogers", Alias = "Capitán América", Team = "Avengers" }
            ];

            //serlalziar la lista a un Json
            var personajeJson = JsonSerializer.Serialize(characters, new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });

            //ahora meter eso a un archivo Json (esto crea el archivo):
            File.WriteAllText("./05 - files/characters.json", personajeJson);


            //Deserialziación:

            //leo el archivo .Json
            var archivoJson = File.ReadAllText("./05 - files/characters.json");

            //deserializar el json a un alista de personajes
                                                           //clase,     archivo leído
            var jsonAList = JsonSerializer.Deserialize<List<Character>>(archivoJson)!;    //<-- Aquí como tal cree una lista que tiene estos objetos


            //recorro la lista
            foreach (var personaje in jsonAList)
            {
                WriteLine($"ID: {personaje.Id}, Name: {personaje.Name}, Alias: {personaje.Alias}, Team: {personaje.Team}");
            
            }



        }
    }
}