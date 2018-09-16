using System;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int opcion = 0;
            do
            {
                Console.WriteLine("1-C9-E1");
                Console.WriteLine("2-C9-E3");
                Console.WriteLine("3-C9-E4");
                Console.WriteLine("4-C12-E1");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Capitulo9.Ejercicio1();
                        break;
                    case 2:
                        Capitulo9.Ejercicio3();
                        break;
                    case 3:
                        Capitulo9.Ejercicio4();
                        break;
                    case 4:
                        Capitulo12.factorial(5);
                        break;
                }
            } while (opcion != -1);
        }
    }
}
