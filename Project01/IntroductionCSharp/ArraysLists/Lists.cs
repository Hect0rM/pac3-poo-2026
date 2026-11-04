using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.IntroductionCSharp.ArraysLists
{
    public class Lists
    {
        public void Products()
        {
            List<string> products = new List<string>();

            products.Add("Semitas");//aqui se agregan los productos a la lista
            products.Add("Cafe");
            products.Add("Galletas");
            products.Insert(0, "Azucar");
            products.Insert(2, "Chocolate");
            products.Remove("Galletas");// por que la lista es string me pide un string si fuera int lo pediria
            products.RemoveAt(0);

           // products.Sort();//lo arganiza por orde Afabetico
           //products.Reverse(); lo ordenaria  desendente
           //product.Clear(); Limpiaria todo o lo borraria

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            products.Contains("Semitas");

            Console.WriteLine($"Total de productos de la lista: {products.Count}");
        }

        public void Menu()
        {
 
            List<string> products = new List<string>();
            string agregar = "";
            string eliminar = "";
            int num = 0;

            while (num != 4)
            {
                Console.WriteLine("\nLISTA DE COMPRA");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Ver Lista");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Seleccione una opcion:");

                num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    Console.WriteLine("Que desea agregar:");
                    agregar = Console.ReadLine();
                    products.Add(agregar);
                }
                else if (num == 2)
                {
                    foreach (var product in products)
                    {
                        Console.WriteLine(product);
                    }
                }
                else if (num == 3)
                {
                    Console.WriteLine("Que desea eliminar:");
                    eliminar = Console.ReadLine();

                    if (products.Remove(eliminar))
                    {
                        Console.WriteLine("Producto eliminado.");
                    }
                    else
                    {
                        Console.WriteLine("El producto no existe en la lista.");
                    }
                    }
                    else if (num == 4)
                    {
                    Console.WriteLine("Saliendo del programa...");
                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida.");
                    }
                }


        }
        public void ListProducts()
        {
            string pro;
            int n=0;
            List<string> products = new List<string>();
            while (n!=4)
            {
                Console.WriteLine("");
                Console.WriteLine("---LISTA DE COMPRAS");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Ver Lista");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Salir");
                n = int.TryParse(Console.ReadLine(), out int s) ? s : 0;
                Console.WriteLine("");
                if (n==1)
                {
                    Console.WriteLine("Ingrese el producto nuevo");
                    pro = Console.ReadLine();
                    products.Add(pro);
                }else if (n==2)
                {
                    products.Sort();
                    foreach (var product in products)
                    {
                        Console.WriteLine(product);
                    }
                }else if (n==3)
                {
                    Console.WriteLine("Ingrese el producto nuevo");
                    pro = Console.ReadLine();
                    products.Remove(pro);

                }else if (n>4||n<0)
                {
                    Console.WriteLine("Numero no valido");
                    
                }
                
            }
        }
    }
}