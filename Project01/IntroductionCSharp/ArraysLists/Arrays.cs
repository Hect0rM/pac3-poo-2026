using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

//Un arreglo o Arrays cuando lo definimos las Posisiciones o cuantos espacis de almacenamiento 

namespace Project01.IntroductionCSharp.ArraysLists
{
    public class Arrays
    {
        public void Numbers(int length )
        {
            //number.Length es para el Length ose lo largo que es cuanto tiene depediendo lo que uno ponga 
            int[] numbers  = new int[length];
            int[] pares = new int[] {2,4,6,8,10};
            string[] nombres = {"Pedro", "Juan", "Pablo", "Maria", "Mateo", "Magdalena"};

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Ingrese un numero para la posicion {i + 1}");
                numbers[i] = int.TryParse(Console.ReadLine(), out int n) ? n: 0;
            } 

            int avg = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                avg += numbers[i];
                // avg = avg + numbers[i];
            }
            avg = avg/numbers.Length;

            Console.WriteLine($"El promedio de los numeros es: {avg}");

        }
    }
}