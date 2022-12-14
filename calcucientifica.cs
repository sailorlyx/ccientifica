using System;

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

            switch (Console.ReadLine())
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

            switch (Console.ReadLine())
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
            Console.WriteLine("4. calcular número factorial");
            Console.WriteLine("5. elevar un número al cuadrado");
            Console.WriteLine("6. calcular modulo");
            Console.WriteLine("7. calcular inverso");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("¡has elegido calcular las funciones trigonometricas!");
                    FuncionesTrigonometricas();
                    break;
                case "2":
                    Console.WriteLine("¡has elegido calcular el valor absoluto!");
                    CalcularValorAbsoluto();
                    break;
                case "3":
                    Console.WriteLine("¡has elegido calcular el numero pi!");
                    CalcularNumPi();
                    break;
                case "4":
                    Console.WriteLine("¡has elegido calcular el numero factorial!");
                    CalcularNumFactorial();
                    break;
                case "5":
                    Console.WriteLine("¡has elegido elevar un numero al cuadrado!");
                    ElevarAlCuadrado();
                    break;
                case "6":
                    Console.WriteLine("¡has elegido calcular el modulo!");
                    CalcularModulo();
                    break;
                case "7":
                    Console.WriteLine("¡has elegido calcular el inverso!");
                    CalcularInverso();
                    break;
                default:
                    Console.WriteLine("porfi elige algo que exista :(");
                    break;
            }

        }
        static void CalcularValorAbsoluto()
        {
            double numerito = PedirNum("dime un numerito");
            double valorAbs;

            if (numerito < 0)
            {
                valorAbs = numerito * -1;
                Console.WriteLine("el valor absoluto de {0} es {1}", numerito, valorAbs);
            }
            else
            {
                valorAbs = numerito;
                Console.WriteLine("el valor absoluto de {0} es {1}", numerito, valorAbs);

            }

        }

        static void CalcularNumPi()
        {
            double numPi = 3.14159;
            double numerito1 = PedirNum("dime un numerito");
            Console.WriteLine("¿que te gustaria hacer con tu numero y el numero pi? (suma, resta, multiplicacion, division)");

            switch (Console.ReadLine())
            {
                case "suma":
                    Console.WriteLine("el total de la suma es " + (numerito1 + numPi));
                    break;
                case "resta":
                    Console.WriteLine("el total de la resta es " + (numerito1 - numPi));
                    break;
                case "multiplicacion":
                    Console.WriteLine("el total de la multiplicacion es " + (numerito1 * numPi));
                    break;
                case "division":
                    Console.WriteLine("el total de la division es " + (numerito1 / numPi));
                    break;
                default:
                    Console.WriteLine("no has introducido correctamente la operacion que quieres :(( pero que sepas que el numero pi es " + numPi);
                    break;
            }
        }

        static void CalcularNumFactorial()
        {
            double numerito1 = PedirNum("dime un numerito");
            double numFactorial = 1;
            int n;

            for (n = 1; n <= numerito1; n++)
                numFactorial = numFactorial * n;

            Console.WriteLine("el numero factorial de {0} es {1}", numerito1, numFactorial);
        }

        static void ElevarAlCuadrado()
        {
            double numerito1 = PedirNum("dime un numerito que quieras elevar al cuadrado");
            double elevado = numerito1 * numerito1;

            Console.WriteLine("elevar al cuadrado el numerito {0} da {1}", numerito1, elevado);
        }

        static void CalcularModulo()
        {
            double numerito1 = PedirNum("dime un numerito");
            double numerito2 = PedirNum("dime otro numerito");
            double numeroModulo = numerito1 % numerito2;

            Console.WriteLine("el modulo de {0} y {1} es {2}", numerito1, numerito2, numeroModulo);
        }

        static void CalcularInverso() 
        {
            double numerito1 = PedirNum("dime un numerito y calculo su inverso");
            double inverso = 1 / numerito1;

            Console.WriteLine("el inverso de {0} es {1} ", numerito1, inverso);

        }

        static void FuncionesTrigonometricas()
        {
            Console.WriteLine("¿que funcion te gustaria hacer?");
            Console.WriteLine("1.calcular seno");
            Console.WriteLine("2.calcular coseno");
            Console.WriteLine("3.calcular tangente");
            Console.WriteLine("4.calcular hipotenusa");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("has elegido calcular el seno");
                    CalcularSeno();
                    break;
                case "2":
                    Console.WriteLine("has elegido calcular el coseno");
                    CalcularCoseno();
                    break;
                case "3":
                    Console.WriteLine("has elegido calcular la tangente");
                    CalcularTangente();
                    break;
                case "4":
                    Console.WriteLine("has elegido calcular la hipotenusa");
                    CalcularHipotenusa();
                    break;
                default:
                    Console.WriteLine("elige una de las opciones disponibles, porfi");
                    FuncionesTrigonometricas();
                    break;
            }

        }

        static void CalcularSeno()
        {
            double catetoOpuesto = PedirNum("dime el cateto opuesto");
            double hipotenusa = PedirNum("dime la hipotenusa");
            double seno = catetoOpuesto / hipotenusa;

            Console.WriteLine("el seno es " + seno);
        }

        static void CalcularCoseno()
        {
            double catetoAdyacente = PedirNum("dime el cateto adyacente");
            double hipotenusa = PedirNum("dime la hipotenusa");
            double coseno = catetoAdyacente / hipotenusa;

            Console.WriteLine("el coseno es " + coseno);
        }

        static void CalcularTangente()
        {
            double catetoOpuesto = PedirNum("dime el cateto opuesto");
            double catetoAdyacente = PedirNum("dime el cateto adyacente");
            double tangente = catetoOpuesto / catetoAdyacente;

            Console.WriteLine("la tangente es " + tangente);

        }
        static void CalcularHipotenusa()
        {
            double cateto1 = PedirNum("dime el primer cateto");
            double cateto2 = PedirNum("dime el segundo cateto");
            double hipotenusa = (cateto1 * cateto1) + (cateto2 * cateto2);

            Console.WriteLine("la hipotenusa es " + hipotenusa);

        }
    } 
}