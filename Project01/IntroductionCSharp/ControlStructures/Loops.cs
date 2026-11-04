using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.IntroductionCSharp.ControlStructures
{
    public class Loops
    {
        string[] products = {"Laptops", "Mouse" , "Teclado" , "Monior"};
        public void ForEach()
        {
            //for (int i =0; i <=3 ; i++)
            //{
              //  Console.WriteLine(products[i]);
            //}

            foreach (string products in products)
            {
                Console.WriteLine(products);
            }
        }
        public void For()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Iteracion: {i}");
            }
        }

        public void Multiply(int number)
        {
            // si el valor es 0 muestre un menseja que no se puede
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{i} X {number} {i*number}");
            }
        }

//Polimorfismo se usan 2 valores a pedir se puede usar el mismo nombre solo que se declare que ocupa 2
        public void Multiply(int number, int limit)
        {
            // si el valor es 0 muestre un menseja que no se puede
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{i} X {number} {i*number}");
            }
        }

        public void Limite(int numero, int lim)
        {
            for (int i = 1; i <= lim ; i++ )
            {
                Console.WriteLine($"{i} X {numero} {i*numero}");
            }
        }

        //While o Mientras
        public void While()
        {
            int i = 1;
            while(i <= 5)
            {
                Console.WriteLine($"Interacion: {i}");
                i++;
            }
        }

        public void WhileRev()
        {
            int i = 5;
            while(i >= 1)
            {
                Console.WriteLine($"Interacion: {i}");
                i--;
            }
        }

        public void WhileMult()
        {
            int i =1;
            while(i <= 12)
            {
                Console.WriteLine($"{i} X 12 = {i*12}");
                i++;
            }
        }

        //ForEach segun el ing muy util
        public void Arbol(int n)
        {
            int digits =  n.ToString().Length; //lo convertira en modo string 

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n - i ; j++)
                {
                    Console.Write($" ");
                    
                }
                for (int number = 1; number <= i; number++)
                {
                    Console.Write(number);
                    if (number < i) Console.Write(" ");

                }
                Console.WriteLine();
            }

        }

        public void WhilePyramid(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n - i ; j++)
                {
                    Console.Write($" ");
                    
                }
                for (int number = 1; number <= i; number++)
                {
                    Console.Write(number);
                    if (number < i) Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
        


    }
}