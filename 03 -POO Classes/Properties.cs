partial class Program
{
    static void Properties()
    {
        
        //Instancia del animal
        Animal animal = new Animal("Bosque");
        animal.Especie = "Lobo";
        animal.Age = 5;

        WriteLine($"Donde vive: {animal.Habitat} y es un animal de especie {animal.Especie} y su su categoria es {animal.Category}");





    }
}

class Animal
{
    public string Especie {get; set;} = "Desconocido";
    public string Category {get;} = "Vertebrado";

    //retornar el get(mostrarlo) y vaidar el set:
    private int age;   //el de aqui 
    public int Age    //el que me mandan
    {
        get {return age;}
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("La edad no puede ser negativa"); 
            }

            age = value;
        }
    }

    public string Habitat {get;}

    public Animal(string habitat)
    {
        Habitat = habitat;
    }


}