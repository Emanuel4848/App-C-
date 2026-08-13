partial class Program
{
    static void Conversions()
    {
        
        //implicita
        double explicitDecimal = 45.5;
        int aInt = (int)explicitDecimal; //indico explicitamente

        //WriteLine(aInt); //imprime 45, pierde el .5



        //convert o parse

        //parse
        string texto = "123";
        int parsedNumber = int.Parse(texto);

        WriteLine(parsedNumber); //imprime 123

        //covert
        double otroDecimal = 50.8;
        WriteLine($"El decimal es: {otroDecimal}");
        int aEntero = Convert.ToInt32(otroDecimal); //redondea, imprimer 51 y es INT
        WriteLine($"Convert: {aEntero}");

        //con casted
        int aEnteroConCasteo = (int)otroDecimal;  //no redondea, explicita, imprime 50, pierde decimal y es INT

        WriteLine($"casteo explicito: {aEnteroConCasteo}");
    }
}