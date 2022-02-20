using System;

namespace mapaDeAprendizaje
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int aspirantes;
            Console.WriteLine("Ingrese la cantidad de aspirantes: ");
            aspirantes = Convert.ToInt32(Console.ReadLine());
            int cont = 0;
            int anhos = 0;
            int media = 0;
            
            do
            {
                Console.WriteLine("Ingrese el anho del aspirante "+ (cont+1)+ " :");
                anhos += Convert.ToInt32(Console.ReadLine());
                
                cont++; 

            } while (cont < aspirantes);

            media = anhos / aspirantes;

            Console.WriteLine("La media de anhos es: " + media);

            
        }
    }
}
