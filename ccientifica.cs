using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccientifica
{
    internal class Program
    {
        public static string Main(string[] args)
        {
        return EjecutarCalcu();
        }

        public static double EjecutarCalcu()
        {
            Console.WriteLine("¡bienvenido a la calculadora cientifica! ¿qué operación te gustaría realizar? :D ");
            return MenuCalcu();
        }

        public static double MenuCalcu()
        {
            
            Console.WriteLine("1. operaciones elementales (+, -, *, /) ");
            Console.WriteLine("2. otras");
            
            switch(Console.ReadLine()) 
            {
                case "1":
                    return OperacionElem();
                    break;


                case "2":
                    Console.WriteLine("has elegido realizar otra operación");
                    break;

                default:
                    Console.WriteLine("tienes que elegir una de las dos opciones :(( ");
                    break;
            }
        }

        public static double PedirNum()
        {
            double numerito1;
            Console.WriteLine("dime un numerito");
            numerito1 = Convert.ToDouble(Console.ReadLine());
            return numerito1;

            double numerito2;
            Console.WriteLine("dime otro numerito :D");
            numerito2 = Convert.ToDouble(Console.ReadLine());
            return numerito2;


        }

        public static double OperacionElem()
        {
            Console.Write("¡has elegido hacer una operacion elemental! ");
            return PedirNum();
            Console.Write("introduce 'suma', 'resta', 'multiplicacion' o 'division' ");

            switch(Console.ReadLine())
            {
                case "suma":
                    Console.WriteLine("el total es " + (numerito1 + numerito2));
                    break;
                case "resta":
                    Console.WriteLine("el total es " + (numerito1 - numerito2));
                    break;
                case "multiplicacion":
                    Console.WriteLine("el total es " + (numerito1 * numerito2));
                    break;
                case "division":
                    Console.WriteLine("el total es " + (numerito1 / numerito2));
                    break;

            }
        }

     
    }
}
