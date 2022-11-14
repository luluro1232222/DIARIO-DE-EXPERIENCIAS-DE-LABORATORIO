using System;

class Program
{
    static void Main()
    {
        
        int[] niveles = new int[5];
        int[] niños = new int[5];
        int[] mujeres = new int[5];
        int suma = 0;
        int nivelmenor = 0;
        int respuesta = 0;


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese la cantidad de niños por nivel ");
            niños[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de mujeres por nivel ");
            mujeres[i] = int.Parse(Console.ReadLine()); 
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("nivel"+(i+1));
            Console.WriteLine(niños[i] + mujeres[i]);
            
        }

        for (int i = 0; i < 5; i++)
        {
          suma+= niños[i] + mujeres[i];
            Console.WriteLine("en el nivel"+ (i+1) +"estan"+suma+ "personas");
        }


        for (int i = 0; i <5 ; i++)
        {
            if(nivelmenor< niños[i])
                {
                nivelmenor = niños[i];
                respuesta = i + 1;
            }
           
        }
        Console.WriteLine("el nivel con mas niños es "+ nivelmenor);
    }
}