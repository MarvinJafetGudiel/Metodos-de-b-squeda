using System;

namespace Busquedas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 2, 5, 8, 12, 16, 23, 38, 45, 56, 72 };

            Console.WriteLine("Numeros en el arreglo:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }

            Console.WriteLine("\n\nIngrese el numero que desea buscar:");
            int numeroBuscar = int.Parse(Console.ReadLine());

            int resultadoLineal = BusquedaLineal(numeros, numeroBuscar);
            int resultadoBinaria = BusquedaBinaria(numeros, numeroBuscar);

            Console.WriteLine("\n--- RESULTADOS ---");

            if (resultadoLineal != -1)
            {
                Console.WriteLine("Busqueda Lineal: Numero encontrado en la posicion " + resultadoLineal);
            }
            else
            {
                Console.WriteLine("Busqueda Lineal: Numero NO encontrado");
            }

            if (resultadoBinaria != -1)
            {
                Console.WriteLine("Busqueda Binaria: Numero encontrado en la posicion " + resultadoBinaria);
            }
            else
            {
                Console.WriteLine("Busqueda Binaria: Numero NO encontrado");
            }

            Console.ReadKey();
        }

        static int BusquedaLineal(int[] arreglo, int numero)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == numero)
                {
                    return i; 
                }
            }

            return -1; 
        }

        static int BusquedaBinaria(int[] arreglo, int numero)
        {
            int inicio = 0;
            int fin = arreglo.Length - 1;

            while (inicio <= fin)
            {
                int mitad = (inicio + fin) / 2;

                if (arreglo[mitad] == numero)
                {
                    return mitad;
                }
                else if (numero < arreglo[mitad])
                {
                    fin = mitad - 1;
                }
                else
                {
                    inicio = mitad + 1;
                }
            }

            return -1; 
        }
    }
}