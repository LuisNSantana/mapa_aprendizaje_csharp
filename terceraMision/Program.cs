using System;
using System.Linq;

namespace terceraMision
{
    class MainClass
    {
        public static void calcularMaxMin(int[] numeros)
        {

            int max = numeros[0];
            int min = numeros[0];
            int contador = 0;

           /* for (int i = 0; i < numeros.Length; i++)
            {

                Console.Write(numeros[i] + "|");


            }*/
            while (contador < numeros.Length)
            {
                if (numeros[contador] > max)
                {
                    max = numeros[contador];
                }

                if (numeros[contador] < min)
                {
                    min = numeros[contador];
                }
                contador++;
            }

            Console.WriteLine(" el sueldo mas alto es: " + max);
            //Console.WriteLine("el numero menor es: " + min);


        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numeros de empleados: ");
            int numEmpleados = Convert.ToInt32(Console.ReadLine());
            int cont = 0;
            int[] sueldo = new int[numEmpleados];
            int aux;
            do {
               

                Console.WriteLine("Ingrese el sueldo del empleado numero " + (cont + 1) + ":");
                aux = Convert.ToInt32(Console.ReadLine());
                sueldo[cont] = aux;
                cont++;
                

            } while (cont < numEmpleados);

            calcularMaxMin(sueldo);


        }
    }
}
