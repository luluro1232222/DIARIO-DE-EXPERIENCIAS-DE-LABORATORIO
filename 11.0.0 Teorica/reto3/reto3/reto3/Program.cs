using System;

class Program
{
    static void Main()
    {

        int[] niveles = new int[5];
        int[] niños = new int[5];
        int[] adultos = new int[5];
        string[] responsable = new string[5];
        int suma = 0;
        int cantidadpersonas = 0;
        int respuesta = 0;
        string encargadomayor="";

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese la persona responsable por nivel ");
            responsable[i] = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de niños por nivel ");
            niños[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de mujeres por nivel ");
            adultos[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("nivel" + (i + 1));
            Console.WriteLine(niños[i] + adultos[i]+"con responsable"+ responsable[i]);

        }

        for (int i = 0; i < 5; i++)
        {
            suma += niños[i] + adultos[i];
            Console.WriteLine("en el nivel" + (i + 1) + "estan" + suma + "personas");
        }


        for (int i = 0; i < 5; i++)
        {
            if (cantidadpersonas < niños[i]+ adultos[i])
            {
                cantidadpersonas = niños[i] + adultos[i];
                respuesta = i + 1;
                encargadomayor = responsable[i];

            }

        }
        Console.WriteLine("el responsable del nivel con mas personas es " + encargadomayor);
    }
}