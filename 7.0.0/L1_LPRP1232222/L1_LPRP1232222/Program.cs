class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su nombre: ");
        string Nombre = Console.ReadLine();
        
        Console.WriteLine("Hola Mundo");
        Console.WriteLine("Soy "+ Nombre); 
        /* Console.WriteLine escribe en diferentes líneas y Console.Write escibe el texto de largo o en la misma línea*/ 

        Console.Write("Hola Mundo");
        Console.Write("Soy "+ Nombre);
        Console.ReadKey();
    }
}
