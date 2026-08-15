partial class Program
{
    static void Visibility()
    {
        
        Jedi jedi = new Jedi();
        jedi.NivelPoder = 500;
        jedi.ColorLaser = "Azul";

        //WriteLine(jedi.CampoPublico);
        //jedi.RevelarSecretos();
        //jedi.UsarFuerza();
        
        Sith sith = new Sith();
        sith.VerProtegidso();
        

    }
}

class Jedi
{
    public string CampoPublico = "Soy un Jedi y mi poder es conocido";
    
    private string CampoPrivado = "Mis pensamientos mas profundos son privados";

    protected string CampoProtegido = "El lado oscuro no debe conocer mis secretos";

    public int NivelPoder {get; set;}
    public string? ColorLaser {get; set;}


    //metodos

    public void RevelarSecretos()
    {
        WriteLine(CampoPrivado);
        WriteLine(CampoProtegido);
    }


    public void UsarFuerza()
    {
        WriteLine($"Soy un jedi con un sable de luz {ColorLaser} y mi nivel de poder es {NivelPoder}");
    }

    private void Meditacion()
    {
        WriteLine("Esoy en profunda meditacion con la furzaa");
    }

    protected void Entrenamiento()
    {
        WriteLine("Estoy entrenando para convertirnme en el mejor Jedi");
    }
}

class Sith: Jedi
{
    public void VerProtegidso()
    {
        WriteLine(CampoProtegido);
        Entrenamiento();
    }
}