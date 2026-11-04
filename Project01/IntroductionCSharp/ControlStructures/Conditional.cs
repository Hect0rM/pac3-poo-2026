using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.IntroductionCSharp.ControlStructures
{
    public class Conditional
    {
        // if => si 
        public void If()
        {
            int age = 20;

            if(age >= 18 )
            {
                Console.WriteLine("Es mayor de edad");
                return; // aqui termina asi que si se cumple no continuara lo que salga despues de del IF
            }//else
            //{
            Console.WriteLine("No es mayor de edad");
            //}
        }

        // switch => Evaluar casos
        public void SwitchClassic()
        {
            int numberDay = 3;

            switch (numberDay)
            {
                case 1: 
                    Console.WriteLine("Domingo");
                    break;
                case 2: 
                    Console.WriteLine("Lunes");
                    break;
                case 3: 
                    Console.WriteLine("Martes");
                    break;
                case 4: 
                    Console.WriteLine("Miercoles");
                    break;
                case 5: 
                    Console.WriteLine("jueves");
                    break;
                case 6: 
                    Console.WriteLine("Viernes");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("Dia no Valido");
                break;
            }
        }

        // Operador de ternario = es una condicion if pero abreviada 
        public void OperadorTernario()
        {
            int age = 21;
            string message = (age > 18)? "Mayor de edad" : "Menor de edad";

            Console.WriteLine(message);
            // string hola = Console.ReadLine(); <--- esto es para pedir la info 
        }

        //switch expression 
        public void SwitchExpression()
        {
            int numberDay = 3;
            string dayname = numberDay switch
            {
                1 => "Domingo",
                2 => "Lunes",
                3 => "Marter",
                4 => "Miercoles",
                5 => "Jueves",
                6 => "Viernes",
                7 => "Sabada",
                _ => "Dia no valido"
            };

            Console.WriteLine(dayname);
        }

    }
}