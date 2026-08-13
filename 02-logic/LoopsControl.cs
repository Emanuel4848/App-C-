partial class Program
{
    static void LoopControl()
    {
        
        for (int i = 0; i< 5; i++)
        {
            if (i==3)
            {
                //return; //llega aqui y acaba
            }
            //WriteLine(i); 
        }



        //bucle infinito

        for (;;)
        {
            WriteLine("Esto es infinito con for");
        }

    }
}