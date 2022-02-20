using System;

namespace quintaMision
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero del 1 al 10: ");
            int num = Convert.ToInt32(Console.ReadLine());

            string cont = "";

            for(int i = num; i < 11; i++)
            {
                cont += i;

                Console.WriteLine(cont);

            }
        }
    }
}
