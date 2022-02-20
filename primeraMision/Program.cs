using System;

namespace primeraMision
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numCiudades = 0;
            Console.WriteLine("Ingresa el numero de ciudades: ");
            numCiudades = Convert.ToInt32(Console.ReadLine());
            int cont = 0;
            int aux = 0;
            string tipCiudades = "";
            string tipCiudades2 = "";
            string[] ciudades = new string[numCiudades];
            string[] ciudades2 = new string[numCiudades];

            
                 do
                {
                
                Console.WriteLine("Ingrese ciudad: ");
                tipCiudades = Console.ReadLine();

                ciudades[cont] = tipCiudades;
                cont++;


                } while (cont < numCiudades || tipCiudades == "quit");



                do
                {

                    Console.WriteLine("preguntame una ciudad: ");
                    tipCiudades2 = Console.ReadLine();

                    int contador = 0;
                    bool ok = false;


                    while (ciudades[contador] != tipCiudades2 && contador < ciudades.Length -1)
                        {

                  
                        if (ciudades[contador] == tipCiudades2) {

                        ok = true;
                        }
                        contador++;


                        }

                    if (!ok)
                    {

                    Console.WriteLine("si has estado");
                    }
                    else
                    {
                    Console.WriteLine("no has estado");
                    }


                }while (tipCiudades2 != "quit");

                
       

            /*for(int i = 0; i < ciudades.Length; i++)
            {
                Console.Write(ciudades[i] + "|");
            }*/
        }
    }
}
