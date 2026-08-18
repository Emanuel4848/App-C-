using System.Runtime.InteropServices.Marshalling;

partial class Program
{

    //Inicializo una variable
    static string? monto;
    static void ManejandoException()
    {
        try
        {
            //leo la entreada
            Write("Ingrese un monto: ");
            monto = ReadLine();

            //Verifico si la entrada es vacio o Null, si se cumple, retorna y acaba.
            if (string.IsNullOrEmpty(monto)) return;


            //Error de conversión: Verifica si se puede parsear o no
            //                   (entrada, salida)
            if (double.TryParse(monto, out double montoParseado))
            {
                WriteLine($"El monto ingresado es de: {montoParseado:C}");
            } else
            {
                WriteLine("No se pudo convertir el texto a numero");
            }


            ValidateAge(16);

        }
        catch (DivideByZeroException)
        {

            WriteLine("Error, división por cero");
        }

        catch (FormatException) when (monto?.Contains('$') == true)
        {

            WriteLine("No es necesario usar el simbolo de dolar");
        } catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine(ex.Message);
        }
        finally
        {
            WriteLine("Estosiempre se ejecuta chaval");
        }
        
    }

    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new ArgumentException("La edad debe ser mayo a 18");
        }
    }
    
}