using System;

namespace cuartaMision
{
    class MainClass
    {
        public static void calcularMaxMin(int[] numeros, string []lenguaje)
        {

            int max = numeros[0];
            int min = numeros[0];
            int contador = 0;
            string lenguajito = lenguaje[0];
            string lengua_max = lenguaje[0];

            /* for (int i = 0; i < numeros.Length; i++)
             {

                 Console.Write(numeros[i] + "|");


             }*/
            while (contador < numeros.Length)
            {
                if (numeros[contador] > max)
                {
                    max = numeros[contador];
                    lengua_max = lenguaje[contador];
                }

                if (numeros[contador] < min)
                {
                    min = numeros[contador];
                    lenguajito = lenguaje[contador];
                }
                contador++;
            }

            Console.WriteLine("La valoracion mas alta es: " + max + " "+lengua_max);
            Console.WriteLine("La valoracion mas baja es: " + min + " "+ lenguajito);


        }

        public static void Main(string[] args)
        {
            string [] nomLenguajes = new string[5];
            int cont = 0;
            string aux;
            int []valoracion = new int [5];
            int nota; 

            do {
                Console.WriteLine("Ingrese el nombre de lenguaje: ");
                aux = Console.ReadLine();
                nomLenguajes[cont] = aux;
                Console.WriteLine("Ingrese la valoracion de conocimiento del lenguaje solo numeros " + nomLenguajes[cont] + ":");
                nota = Convert.ToInt32(Console.ReadLine());
                valoracion[cont] = nota;
                cont++;
            } while (cont < nomLenguajes.Length);

            calcularMaxMin(valoracion, nomLenguajes);
        }
    }
}
