using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Project01.IntroductionCSharp.Operators.Logic
{
    public class Compare
    {
        private int x = 20;
        private int y = 25;

        private int z =22;

        public void Valid()
        {
            Console.WriteLine ("Es igual  x y x: " + (x == y));
            Console.WriteLine ("No es igual  x y x: " + (x != y));
            Console.WriteLine ("Es mayor  x y x: " + (x > y));
            Console.WriteLine ("Es menor  x y x: " + (x < y));
            Console.WriteLine ("Es mayor o igual  x y x: " + (x >= y));
            Console.WriteLine ("Es Menor o igual  x y x: " + (x <= y));

            // && AND
            Console.WriteLine("Z es mayor que X y menor que Y: " + ( z > x && z < y ));
            // || OR
            Console.WriteLine("Z es mayor que X o menor que Y: " + ( z > x || z < y ));

            //Interporlacion de String
            Console.WriteLine($"{z} es Mayor que {x} y menor que {y}: {z > x && z < y}");


        }

        //Van a creear un metodo llamado VALIDINTERPOLATION como en la interpolacion 

        public void Validinterpolation ()
        {
            Console.WriteLine ($"Es igual  {x} y {y}: {x == y}");
            Console.WriteLine ($"No es igual  {x} y {y}: {x != y}");
            Console.WriteLine ($"Es mayor  {x} y {y}: {x > y}");
            Console.WriteLine ($"Es menor  {x} y {y}: {x < y}");
            Console.WriteLine ($"Es mayor o igual  {x} y {y}: {x >= y}");
            Console.WriteLine ($"Es Menor o igual  {x} y {y}: {x <= y}");
        }

        


    }
}