partial class Program
{
    static void LoopGame()
    {
        int contador = 0;
        WriteLine("Pulsa cualquier tecla para aumentar el contador");
        WriteLine("Presiona ESC para salir \n ");
        
        while(true)
        {
            var key = Console.ReadKey(true).Key;       //capturar la tecla precionada

            if (key == ConsoleKey.Escape)
            {
                WriteLine($"Has pulsado las teclas {contador} veces antes de salir");
                WriteLine("Ha terminado el programa");
                break;  //si es ESC pues corto el loop.
            } else
            {
                contador++;        //si la tecla precionada no es ESC, entonce sumo +1 al contador
            }
        }
    }
}