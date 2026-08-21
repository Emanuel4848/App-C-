using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

partial class Program
{
    static void Linq()
    {
        
        List<int> numbers = [1,2,3,4,5,6];  //lsita numeros
        List<int> numbersEnteros = [];      //lista donde se almacenaran los numeros pares

        foreach (var number in numbers)    //bucle donde busco los pares y agrego a lista correspondiente.
        {
            if(number % 2 == 0)
            {
                numbersEnteros.Add(number);
            }
        }

        //Sintaxis de consulta
        var NumerosEnterosQuery = from num in numbers     //num la cree aqui xd
                                  where num % 2 == 0
                                  select num;


        //Sintaxis de metodo
        var NumerosEnterosMetodo = numbers.Where(n => n%2 == 0);

        //ver 
        foreach (var number in NumerosEnterosQuery)
        {
            //WriteLine(number);
        }






        //Consultas simple
        List<MarvelCharacter> characters = new List<MarvelCharacter>
        {
        new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
        new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
        new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
        new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
        new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
        new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
        };



        //consulta 5

        var PrimerRegistroQuery = (from a in characters
                                  select a).First();

       // WriteLine(PrimerRegistroQuery.Name);

        var PrimerRegistroMetodh = characters.First();

        WriteLine(PrimerRegistroMetodh.Name);

        //constla 4
       // WriteLine("Primer 3 elementos");

        var PrimerosTresQuery = (from a in characters
                                select a).Take(3);


        var PrimerosTresMetod = characters.Take(3);

        foreach (var avg in PrimerosTresMetod)
        {
          //  WriteLine(avg.Name);
        }



        //Consulta 3
        //WriteLine("Select everyone's name en orden descen z-a");

        var NameSortedQuery = from avenxd in characters
                           orderby avenxd.Name descending
                           select avenxd.Name;

        var NameSortedMetod = characters.OrderByDescending(avenger => avenger.Name);


        foreach(var avg in NameSortedMetod)
        {
        //    WriteLine(avg.Name);
        }










        //Consulta 1:
       

        //por query
        var AvengersQuery = from xd in characters
                            where xd.Team == "Avengers"
                            select $"{xd.Name} {xd.Alias}";

        //por metodo
        var AvengersMetod = characters.Where( xd => xd.Team == "Avengers");

        foreach (var avenger in AvengersMetod)
        {
            //WriteLine($"{avenger.Name} {avenger.Alias}");
        }


         //Consulta 2:
        // WriteLine("Nombres de todos en mayusculas");

         //por query
        var NombresMayusculasQuery = from aveng in characters
                                     select aveng.Name?.ToUpper();


        //por metodo
        var NombresMayusculasMetod = characters.Select( aveng => aveng.Name?.ToUpper());


        //ver si funciono xd
        foreach (var avenger in NombresMayusculasMetod)
        {
            //WriteLine(avenger);
        }
        
    }
   
}

class MarvelCharacter
{
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
}

