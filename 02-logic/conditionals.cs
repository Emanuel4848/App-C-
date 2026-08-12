partial class Program
{
    static void Conditionals()
    {
        
        int age = 19;

        if(age >= 18)
        {
            WriteLine("Es mayor de edad");
        } else
        {
            WriteLine("Es menor de edad");
        }

        //if ternario
        string message = age >= 18 ? "Es mayor de edad": "Es manor de edad";
        WriteLine(message);

        //multiples condiciones
        int temperatura = 30;

        if (temperatura >= 35)
        {
            WriteLine("Hace mucho calor");
        } else if (temperatura >= 20)
        {
            WriteLine("Estas en una tempertaura agradable");
        } else
        {
            WriteLine("Hace frio xd");
        }

        //swtich
        WriteLine("Ingrese un numero de 1 a 5 (Lunes=1, martes= 2...): ");
        int day = int.Parse(ReadLine()!);

        switch (day)
        {
            case 1:
                WriteLine("Lunes");
                break;
            case 2:
                WriteLine("Martes");
                break;
            case 3:
                WriteLine("Miercoes");
                break;
            case 4:
                WriteLine("Jueves");
                break;
            case 5:
                WriteLine("Virnes");
                break;
            case 6 or 7:
                WriteLine("Fin de semanda");
                break;
            default:
                WriteLine("No valido");
                break;
        }

            
        string diaSemana = day switch
        {
            1 => "Lunes",
            2 => "Martes",
            3 => "Mircoles",
            4 or 5 or 6 or 7 => "Otros dias",
            _ => "Dia no valido"   //default
        };
        WriteLine(diaSemana);


    }
}