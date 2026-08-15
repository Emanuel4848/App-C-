partial class Program
{
    static void herencia()
    {
        //Objeto Estudiante con atributo de padre(Name) y atributo propio(House)
        EstudianteGT student = new EstudianteGT(){Name = "Harry Potter", House = "Ciudad"};
        
         //Objeto Profesor con atributo de padre(Name) y atributo propio(Materia)
        ProfersorGT professor = new ProfersorGT(){Name= "Severus", Materia="Química"};

        //Metodo de Padre usado en Hijo
        student.Saludar();

        //
        student.ShowHouse();

        //
        professor.MyMateria();
    }
}


//clase Padre (persona)
class Caracter
{
    public string? Name {get; set;}

    //metodo virtual permite sobreescribirlo
    public virtual void Saludar()
    {
        WriteLine($"Hola, soy {Name}");
    }
}

//clase Hija (Estudiante)
//herencia:   hijo : Padre
//Que hereda?: Name, Saludar()
class EstudianteGT: Caracter
{
    public string? House {get; set;}

    public override void Saludar()
    {
        WriteLine($"Hola, soy {Name} y soy estudiante"); //sobreecribir su comportamiento
    }


    public void ShowHouse()
    {
        WriteLine($"Pertenezco a la casa {House} en GT ");
    }
}



class ProfersorGT: Caracter
{
    public string? Materia {get; set;}

    public void MyMateria()
    {
        WriteLine($"Enseño {Materia} en GT");
    }

    public override void Saludar()
    {
        WriteLine($"Hola, soy {Name} y soy profesor"); //sobreecribir su comportamiento
    }
}