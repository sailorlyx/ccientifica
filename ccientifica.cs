using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccientifica
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        EjecutarCalcu();
        }

        public static void EjecutarCalcu()
        {
            Console.WriteLine("¡bienvenido a la calculadora cientifica! ¿qué operación te gustaría realizar? :D ");
            MenuCalcu();
        }

        public static void MenuCalcu()
        {
            
            Console.WriteLine("1. operaciones elementales (+, -, *, /) ");
            Console.WriteLine("2. otras");
            
            switch(Console.ReadLine()) 
            {
               case "1":
                    OperacionElem();
                    break;


               case "2":
                    OtrasOperaciones();
                    break;

                default:
                    Console.WriteLine("tienes que elegir una de las dos opciones :(( ");
                    MenuCalcu();
                    break;
            }
        }

        public static double PedirNum(string peticion)
        {
            double numerito;
            Console.WriteLine(peticion);
            numerito = Convert.ToDouble(Console.ReadLine());
            return numerito;
        }

        public static void OperacionElem()
        {
            Console.Write("¡has elegido hacer una operacion elemental! ");
            double numerito1 = PedirNum("dime un numerito :D");
            double numerito2 = PedirNum("dime otro numerito :P");
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
                default:
                    Console.WriteLine("lo has hecho mal, vuelve a empezar porfi :( ");
                    OperacionElem();
                    break;
            }
        }

        static void OtrasOperaciones()
        {
            Console.WriteLine("¡has elegido hacer otro tipo de operacion! ¿que tipo de operacion te gustaria hacer?");
            Console.WriteLine("1. funciones trigonometricas");
            Console.WriteLine("2. calcular valor absoluto");
            Console.WriteLine("3. calcular con numero pi");
            Console.WriteLine("4. calcular con exponentes");
            Console.WriteLine("5. calcular logaritmo");

            switch(Console.ReadLine())
            {
                case "1":
                    FuncionesTrigonometricas();
                    break;
                case "2":
                    CalcularValorAbsoluto();
                    break;
                case "3":
                    CalcularNumPi();
                    break;
            }


        }

        static void CalcularValorAbsoluto()
        {
           double numerito;
           double valorAbs;

           numerito = PedirNum("dime un numerito");
           
           if (numerito<0) {
             valorAbs = numerito * -1;
             Console.WriteLine("El valor absoluto de {0} es {1}" ,numerito, valorAbs);
            } else {
              valorAbs = numerito;
             Console.WriteLine("El valor absoluto de {0} es {1}" ,numerito, valorAbs);

            }
           
        }

        static void CalcularNumPi()
        {
            double numPi = 3.14159;
            double numerito1;
            numerito1 = PedirNum("dime un numerito");
            Console.WriteLine("¿que te gustaria hacer con tu numero y el numero pi? (suma, resta, multiplicacion, division)");
            
            switch(Console.ReadLine() {
                case "suma":
                    Console.WriteLine("el total de la suma es " + numerito1 + numPi);
                    break;
                case "resta":
                    Console.WriteLine("el total de la resta es " + numerito1 - numPi);
                    break;
                case "multiplicacion":
                    Console.WriteLine("el total de la multiplicacion es "+ numerito1 * numPi);
                    break;
                case "division":
                    Console.WriteLine("el total de la division es "+ numerito1/ numPi);
                    break;
                default:
                    Console.WriteLine("no has introducido correctamente la operacion que quieres :(( pero que sepas que el numero pi es " + numPi);
                    break;
            }
        }

        static void FuncionesTrigonometricas()
        {
            Console.WriteLine("¿que funcion te gustaria hacer?");
            Console.WriteLine("1.calcular seno");
            Console.WriteLine("2.calcular coseno");
            Console.WriteLine("3.calcular tangente");

            switch(Console.ReadLine()) {
                case "1":
                    Console.WriteLine("has elegido calcular el seno");
                    break;
                case "2":
                    Console.WriteLine("has elegido calcular el coseno");
                    break;
                case "3":
                    Console.WriteLine("has elegido calcular la tangente");
                    break;

                default:
                    Console.WriteLine("elige una de las opciones disponibles, porfi");
                    FuncionesTrigonometricas();
                    break;
            }

        }

        static void CalcularSeno()
        {
            //me cago en mi puta vida
        }

     
    }
}
